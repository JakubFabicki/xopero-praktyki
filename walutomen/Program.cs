using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Interactivity;
using DSharpPlus.Entities;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Net;
using System.Net.Http;
using System.Data.SQLite;
using System.Data;


namespace walutomen
{
    class Program
    {
        static void Main(string[] args)
        {
            MainAsync().GetAwaiter().GetResult();
        }

        static async Task MainAsync()
        {
            var discord = new DiscordClient(
            new DiscordConfiguration()
            {
                Token = "OTQxMjc0ODkwOTE5NjEyNDI3.Y//xddd//gTkjg.5Ib62h0SNVFDlqugYGeC8nr2urw",
                TokenType = TokenType.Bot,
                Intents = DiscordIntents.AllUnprivileged,
            });

            var CommandsNext = discord.UseCommandsNext(new CommandsNextConfiguration()
            {
                StringPrefixes = new[] { "!" }
            });


            CommandsNext.RegisterCommands<Kurs>();
            CommandsNext.RegisterCommands<Stats>();

            await discord.ConnectAsync();
            await Task.Delay(-1);
        }


    }

    public class Kurs : BaseCommandModule
    {
        [Command("Kurs")]
        public async Task GreetCommand(CommandContext ctx, string code)
        {
            JsonReader jsonReader = new JsonReader();
            database DB = new database();
            DB.CreateDatabaseAndTable();
            await ctx.RespondAsync($"Aktualny kurs { code.ToUpper() } to: " + jsonReader.json(code));
            if (DB.SelectData(ctx.User.Id, code) == 0)
                DB.AddData(ctx.User.Id, code);
            else
                DB.UpdateData(ctx.User.Id, code);
        }
    }

    public class Stats : BaseCommandModule
    {
        [Command("Stats")]
        public async Task GreetCommand(CommandContext ctx, string code)
        {
            database DB = new database();
            DB.CreateDatabaseAndTable();
            int count = DB.SelectStats(ctx.User.Id, code);
            await ctx.RespondAsync($"Sprawdzałeś walutę { code.ToUpper() } {count} razy");
        }
    }

    public class JsonReader
    {
        static List<JSON> jsons;
        static HttpClient client;

        public string json(string code)
        {
            using (client = new HttpClient())
            {
                var response = client.GetAsync($"http://api.nbp.pl/api/exchangerates/rates/a/{code}/").Result;

                if (response.IsSuccessStatusCode)
                {
                    var responseContent = response.Content;
                    string responseString = responseContent.ReadAsStringAsync().Result;
                    return deserializeJSON(responseString);
                }
                return "";
            }
        }

        private static string deserializeJSON(string json)
        {
            JSON jsonObj;
            jsonObj = JsonSerializer.Deserialize<JSON>(json);
            return jsonObj.rates[0].mid.ToString();
        }
    }
}

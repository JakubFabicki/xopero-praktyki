﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorytmy
{
    public partial class Form1 : Form
    {
        private int time;
        private int points = 0;
        private int failPoints = 0;

        private QuickSort QS;
        private BubbleSort BS;
        private HeapSort HS;
        private Random rand;

        public Form1()
        {
            //init
            InitializeComponent();
            QS = new QuickSort();
            BS = new BubbleSort();
            HS = new HeapSort();
            rand = new Random();
            mainSort();
        }

        private void mainSort()
        {
            //generate number array
            int[] array = randomArrayGen(false);
            int[] arrayBS = randomArrayGen(true);

            //randomize algorithm
            switch (rand.Next(3))
            {
                case 0:
                    Console.WriteLine("MainSort : QuickSort");
                    time = QS.DoAlgorithm(array);
                    randomNum.Text = array.Length.ToString();
                    randomAlg.Text = "QuickSort";
                    break;

                case 1:
                    Console.WriteLine("MainSort : BubbleSort");
                    time = BS.DoAlgorithm(arrayBS);
                    randomNum.Text = arrayBS.Length.ToString();
                    randomAlg.Text = "BubbleSort";
                    break;

                case 2:
                    Console.WriteLine("MainSort : HeapSort");
                    time = HS.DoAlgorithm(array);
                    randomNum.Text = array.Length.ToString();
                    randomAlg.Text = "HeapSort";
                    break;
            }

            Console.WriteLine(time);
            
            answerBtn1.Tag = null;
            answerBtn2.Tag = null;
            answerBtn3.Tag = null;

            //randomize buttons
            int randTime, randTime2;
            do
            {
                randTime = rand.Next(time - 10, time + 10);
                randTime2 = rand.Next(time - 10, time + 10);
            }
            while (randTime == randTime2 && randTime == time && randTime2 == time);
            
            switch (rand.Next(3))
            {
                case 0:
                    answerBtn1.Text = time.ToString();
                    answerBtn1.Tag = "right";
                    answerBtn2.Text = randTime.ToString();
                    answerBtn3.Text = randTime2.ToString();
                    break;

                case 1:
                    answerBtn1.Text = randTime.ToString();
                    answerBtn2.Text = time.ToString();
                    answerBtn2.Tag = "right";
                    answerBtn3.Text = randTime2.ToString();
                    break;

                case 2:
                    answerBtn1.Text = randTime.ToString();
                    answerBtn2.Text = randTime2.ToString();
                    answerBtn3.Text = time.ToString();
                    answerBtn3.Tag = "right";
                    break;
            }
        }

        private int[] randomArrayGen(bool BS)
        {
            int[] array;
            if(BS)
                array = new int[rand.Next(5000, 10000)];
            else
                array = new int[rand.Next(100000, 200000)];

            for (int i = 0; i < array.Length; i++)
                array[i] = rand.Next(1000000);

            return array;
        }

        private void save()
        {
            Base64 b64 = new Base64();
            using (FileStream fs = File.Create(@"c:\temp\score.txt"))
            {
                byte[] info = new UTF8Encoding(true).GetBytes(b64.encodeBase64(failBox.Text));
                fs.Write(info, 0, info.Length);
                byte[] newline = Encoding.ASCII.GetBytes(Environment.NewLine);
                fs.Write(newline, 0, newline.Length);
                info = new UTF8Encoding(true).GetBytes(b64.encodeBase64(rightBox.Text));
                fs.Write(info, 0, info.Length);
            }
        }

        private void answerBtn1_Click(object sender, EventArgs e)
        {
            if(answerBtn1.Tag == "right")
            {
                points++;
                rightBox.Text = points.ToString();
            }
            else
            {
                failPoints++;
                failBox.Text = failPoints.ToString();
            }
            save();
            mainSort();
        }

        private void answerBtn2_Click(object sender, EventArgs e)
        {
            if (answerBtn1.Tag == "right")
            {
                points++;
                rightBox.Text = points.ToString();
            }
            else
            {
                failPoints++;
                failBox.Text = failPoints.ToString();
            }
            save();
            mainSort();
        }

        private void answerBtn3_Click(object sender, EventArgs e)
        {
            if (answerBtn1.Tag == "right")
            {
                points++;
                rightBox.Text = points.ToString();
            }
            else
            {
                failPoints++;
                failBox.Text = failPoints.ToString();
            }
            save();
            mainSort();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] loadPoints = new string[2];
            Base64 b64 = new Base64();
            using (StreamReader sr = new StreamReader(@"c:\temp\score.txt"))
                for (int i = 0; i < 2; i++)
                    loadPoints[i] = sr.ReadLine();
            rightBox.Text = b64.decodeBase64(loadPoints[0]);
            failBox.Text = b64.decodeBase64(loadPoints[1]);
            points = Int32.Parse(rightBox.Text);
            failPoints = Int32.Parse(failBox.Text);
        }
    }

    public interface IAlgorithm
    {
        int[] afterSort{ get; set; }

        int DoAlgorithm(int[] array);
    }

    class QuickSort : IAlgorithm
    {
        public int[] afterSort { get; set; }
        
        public int DoAlgorithm(int[] array)
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            afterSort = quickSort(array, 0, array.Length - 1);
            watch.Stop();
            return (int)watch.ElapsedMilliseconds;
        }
        
        private int[] quickSort(int[] array, int left, int right)
        {
            var i = left;
            var j = right;
            var pivot = array[(i + j) / 2];
            while(i < j)
            {
                while (array[i] < pivot)
                    i++;

                while (array[j] > pivot)
                    j--;

                if (i <= j)
                {
                    var tmp = array[i];
                    array[i++] = array[j];
                    array[j--] = tmp;
                }
            }

            if (left < j)
                quickSort(array, left, j);
            if (i < right)
                quickSort(array, i, right);
            return array;
        }
    }

    class BubbleSort : IAlgorithm
    {
        public int[] afterSort { get; set; }

        public int DoAlgorithm(int[] array)
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            for (int j = 0; j <= array.Length - 2; j++)
            {
                for (int i = 0; i <= array.Length - 2; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        var tmp = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = tmp;
                    }
                }
            }
            watch.Stop();
            return (int)watch.ElapsedMilliseconds;
        }
    }

    class HeapSort : IAlgorithm
    {
        public int[] afterSort { get; set; }

        public int DoAlgorithm(int[] array)
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            int n = array.Length;

            for (int i = n / 2 - 1; i >= 0; i--)
                heapify(array, n, i);

            for(int i = n - 1; i > 0; i--)
            {
                int tmp = array[0];
                array[0] = array[i];
                array[i] = tmp;

                heapify(array, i, 0);
            }
            watch.Stop();

            return (int)watch.ElapsedMilliseconds;
        }

        private void heapify(int[] array, int n, int i)
        {
            int largest = i;
            int l = 2 * i + 1;
            int r = 2 * i + 2;

            if(l < n && array[l] > array[largest])
                largest = l;

            if (r < n && array[r] > array[largest])
                largest = r;

            if(largest != i)
            {
                int swap = array[i];
                array[i] = array[largest];
                array[largest] = swap;

                heapify(array, n, largest);
            }

        }
    }
}       



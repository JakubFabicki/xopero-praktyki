using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorytmy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            mainSort();
            InitializeComponent();
        }

        private void mainSort()
        {
            int[] array = randomArrayGen();

            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            QuickSort QS = new QuickSort();
            int[] bagno = QS.DoAlgorithm(array);
            watch.Stop();

            var watchBubble = new System.Diagnostics.Stopwatch();

            watchBubble.Start();
            int[] bagno2 = bubbleSort(array);
            watchBubble.Stop();

            var watch2 = new System.Diagnostics.Stopwatch();
            watch2.Start();
            for (int i = 0; i < bagno2.Length; i++)
            {
                Console.WriteLine(bagno2[i]);
            }
            watch2.Stop();

            Console.WriteLine($"Quick execution Time: {watch.ElapsedMilliseconds} ms");
            Console.WriteLine($"Bubble execution Time: {watchBubble.ElapsedMilliseconds} ms");
            Console.WriteLine($"Cout execution Time: {watch2.ElapsedMilliseconds} ms");
        }

        private int[] randomArrayGen()
        {
            var rand = new Random();
            var array = new int[10000];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(1000000);
            }

            return array;
        }


        private int[] bubbleSort(int[] array)
        {
            for(int j = 0; j<=array.Length - 2; j++)
            {
                for(int i = 0; i<= array.Length - 2; i++)
                {
                    if(array[i] > array[i + 1])
                    {
                        var tmp = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = tmp;
                    }
                }
            }
            return array;
        }
    }

    public interface IAlgorithm
    {
        int[] afterSort{ get; set; }

        int[] DoAlgorithm(int[] array);
    }

    class QuickSort : IAlgorithm
    {
        public int[] afterSort { get; set; }
        
        public int[] DoAlgorithm(int[] array)
        {
            afterSort = quickSort(array, 0, array.Length - 1);

            return afterSort;
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
        public int[] afterSort { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int[] DoAlgorithm(int[] array)
        {
            throw new NotImplementedException();
        }
    }
}       



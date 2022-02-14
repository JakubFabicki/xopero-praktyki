using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorytmy
{
    public interface IAlgorithm
    {
        int[] afterSort { get; set; }

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
            while (i < j)
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

            for (int i = n - 1; i > 0; i--)
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

            if (l < n && array[l] > array[largest])
                largest = l;

            if (r < n && array[r] > array[largest])
                largest = r;

            if (largest != i)
            {
                int swap = array[i];
                array[i] = array[largest];
                array[largest] = swap;

                heapify(array, n, largest);
            }

        }
    }
}

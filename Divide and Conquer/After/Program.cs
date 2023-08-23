using System;

namespace MergeSortApp
{
	class Program
	{
		static void Merge(int[] array, int left, int middle, int right)
		{
			int n1 = middle - left + 1;
			int n2 = right - middle;

			int[] leftArray = new int[n1];
			int[] rightArray = new int[n2];

			for (int i = 0; i < n1; i++)
				leftArray[i] = array[left + i];
			for (int j = 0; j < n2; j++)
				rightArray[j] = array[middle + 1 + j];

			int k = left;
			int x = 0, y = 0;

			while (x < n1 && y < n2)
			{
				if (leftArray[x] <= rightArray[y])
				{
					array[k] = leftArray[x];
					x++;
				}
				else
				{
					array[k] = rightArray[y];
					y++;
				}
				k++;
			}

			while (x < n1)
			{
				array[k] = leftArray[x];
				x++;
				k++;
			}

			while (y < n2)
			{
				array[k] = rightArray[y];
				y++;
				k++;
			}
		}

		static void MergeSort(int[] array, int left, int right)
		{
			if (left < right)
			{
				int middle = left + (right - left) / 2;

				MergeSort(array, left, middle);
				MergeSort(array, middle + 1, right);

				Merge(array, left, middle, right);
			}
		}

		static void Main(string[] args)
		{
			int[] array = { 12, 11, 13, 5, 6, 7 };

			Console.WriteLine("Unsorted array: " + string.Join(", ", array));

			MergeSort(array, 0, array.Length - 1);

			Console.WriteLine("Sorted array: " + string.Join(", ", array));
		}
	}
}
// menerapkan algoritma pengurutan Merge Sort menggunakan pendekatan Divide and Conquer. 
// Pertama, kita membuat dua fungsi: Merge untuk menggabungkan dua bagian array yang diurutkan, 
// dan MergeSort untuk membagi dan mengurutkan array menggunakan pendekatan Divide and Conquer.
// Dalam fungsi MergeSort, kita membagi array menjadi bagian-bagian yang lebih kecil 
// dan kemudian menggabungkan hasil pengurutan dari setiap bagian. 
// Proses ini terus berlanjut hingga array menjadi terurut secara keseluruhan.
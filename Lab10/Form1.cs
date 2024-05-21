using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace Lab10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public static int[] Chaotic(int length)
        {
            Random random = new Random();
            int[] a = new int[length];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = random.Next(1, 300);
            }
            return a;
        }

       
        public static int[] PartiallySorted(int length)
        {
            Random random = new Random();
            int[] a = new int[length];
            a[0] = random.Next(1, 300);
            for (int i = 1; i < a.Length; i++)
            {
                a[i] = a[i - 1] + random.Next(1, 300);
            }

            int[] b = Chaotic(length / 2);
            for (int i = 0; i < (length / 2); i++)
            {
                a[i] = b[i];
            }
            return a;
        }

        public static int[] Duplicates(int length)
        {
            Random random = new Random();
            int[] a = new int[length];
            for (int i = 1; i < a.Length; i++)
            {
                a[i] = random.Next(1, 300);
                if (a[i] % 2 == 0)
                {
                    a[i] = a[i - 1];
                }
            }
            return a;
        }

        public void BubbleSort(int[] a)
        {
            int temp;
            bool swapped;
            for (int i = 0; i < a.Length - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < a.Length - i - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                        swapped = true;
                    }
                }
                PrintArray(listBox1, a);
                if (!swapped)
                {
                    break;
                }
            }
        }

        public static void Swap(int[] a, int i, int j)
        {
            int temp = a[i];
            a[i] = a[j];
            a[j] = temp;
        }

        public static int Partition(int[] a, int low, int high)
        {
            int pivot = a[high];
            int i = low - 1;
            for (int j = low; j <= high - 1; j++)
            {
                if (a[j] < pivot)
                {
                    i++;
                    Swap(a, i, j);
                }
            }
            Swap(a, i + 1, high);
            return i + 1;
        }

        public void QuickSort(int[] a, int low, int high)
        {
            if (low < high)
            {
                int pivot = Partition(a, low, high);
                QuickSort(a, low, pivot - 1);
                QuickSort(a, pivot + 1, high);
                PrintArray(listBox1, a);
            }
        }

        public void Chaotic_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int length;
            if (!int.TryParse(textBox2.Text.Trim(), out length))
            {
                MessageBox.Show("Будь ласка, введіть коректну довжину масиву!", "Помилка", MessageBoxButtons.OK);
                return;
            }

            int[] a = Chaotic(length);
            PrintArray(listBox1, a);
        }

        public void PartiallySorted_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int length;
            if (!int.TryParse(textBox2.Text.Trim(), out length))
            {
                MessageBox.Show("Будь ласка, введіть коректну довжину масиву!", "Помилка", MessageBoxButtons.OK);
                return;
            }

            int[] a = PartiallySorted(length);
            PrintArray(listBox1, a);
        }

        public void Duplicates_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int length;
            if (!int.TryParse(textBox2.Text.Trim(), out length))
            {
                MessageBox.Show("Будь ласка, введіть коректну довжину масиву!", "Помилка", MessageBoxButtons.OK);
                return;
            }

            int[] a = Duplicates(length);
            PrintArray(listBox1, a);
        }

        public void Bubble_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            TimeSpan timespan = new TimeSpan();
            if (listBox1.Items.Count > 1)
            {
                string firstItem = listBox1.Items[0].ToString();
                listBox1.Items.Clear();
                listBox1.Items.Add(firstItem);
            }
            int[] a = GetArrayFromListBox(listBox1);
            if (a != null)
            {
                stopwatch.Start();
                BubbleSort(a);
                stopwatch.Stop();
                timespan = stopwatch.Elapsed;
                stopwatch.Reset();
                label3.Text = $"Час виконання Бульбашкового сортуванння в мс: " + (double)timespan.Ticks / 10000;
            }
            else
            {
                MessageBox.Show("Помилка: Масив може містити лише цілі числа, розділені пробілами!", "Помилка",
                    MessageBoxButtons.OK);
            }
        }

        public void Quick_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            TimeSpan timespan = new TimeSpan();
            if (listBox1.Items.Count > 1)
            {
                string firstItem = listBox1.Items[0].ToString();
                listBox1.Items.Clear();
                listBox1.Items.Add(firstItem);
            }
            int[] a = GetArrayFromListBox(listBox1);
            if (a != null)
            {
                stopwatch.Start();
                QuickSort(a, 0, a.Length - 1);
                stopwatch.Stop();
                timespan = stopwatch.Elapsed;
                stopwatch.Reset();
                label2.Text = $"Час виконання Швидкого сортування в мс: " + (double)timespan.Ticks / 10000;
            }
            else
            {
                MessageBox.Show("Помилка: Масив може містити лише цілі числа, розділені пробілами!", "Помилка",
                    MessageBoxButtons.OK);
            }
        }

        static void PrintArray(System.Windows.Forms.ListBox listBox1, int[] array)
        {
            listBox1.Items.Add(string.Join(" ", array));
        }

        private int[] GetArrayFromListBox(System.Windows.Forms.ListBox listBox)
        {
            if (listBox.Items.Count == 0)
            {
                MessageBox.Show("Помилка: Масив не може бути порожнім!", "Помилка", 
                    MessageBoxButtons.OK);
                return null;
            }

            try
            {
                string[] stringArray = listBox.Items[0].ToString().Split(new[] { ' ' }, 
                    StringSplitOptions.RemoveEmptyEntries);
                int[] intArray = Array.ConvertAll(stringArray, int.Parse);
                return intArray;
            }
            catch (FormatException)
            {
                MessageBox.Show("Помилка: Масив повинен містити лише цілі числа, розділені пробілами!",
                    "Помилка", MessageBoxButtons.OK);
                return null;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}


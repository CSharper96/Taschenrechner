using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Math;

namespace Taschenrechner
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Queue<int> _IntInputNumber;
        private int _DictCounter = 1;
        private Dictionary<int, Queue<int>> _DictAllInputNumbers;
        private Queue<string> _OperatorQueue;

        public MainWindow()
        {
            _DictAllInputNumbers = new Dictionary<int, Queue<int>>();
            _OperatorQueue = new Queue<string>();
            _IntInputNumber = new Queue<int>();
            InitializeComponent();
        }
        private void VisualizeInput()
        {
            txtbDisplay.Text = "";
            foreach (int number in _IntInputNumber)
                txtbDisplay.Text += number;
        }

        private void Btn0_Click(object sender, RoutedEventArgs e)
        {
            _IntInputNumber.Enqueue(0);
            VisualizeInput();
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            _IntInputNumber.Enqueue(1);
            VisualizeInput();
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            _IntInputNumber.Enqueue(2);
            VisualizeInput();
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            _IntInputNumber.Enqueue(3);
            VisualizeInput();
        }

        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            _IntInputNumber.Enqueue(4);
            VisualizeInput();
        }

        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            _IntInputNumber.Enqueue(5);
            VisualizeInput();
        }

        private void Btn6_Click(object sender, RoutedEventArgs e)
        {
            _IntInputNumber.Enqueue(6);
            VisualizeInput();
        }

        private void Btn7_Click(object sender, RoutedEventArgs e)
        {
            _IntInputNumber.Enqueue(7);
            VisualizeInput();
        }

        private void Btn8_Click(object sender, RoutedEventArgs e)
        {
            _IntInputNumber.Enqueue(8);
            VisualizeInput();
        }

        private void Btn9_Click(object sender, RoutedEventArgs e)
        {
            _IntInputNumber.Enqueue(9);
            VisualizeInput();
        }

        private void BtnMult_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnMinus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnDiv_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnPlus_Click(object sender, RoutedEventArgs e)
        {
            _OperatorQueue.Enqueue("+");
            txtbDisplay.Text += "\n+\n";
            AddNumberToDict();
        }

        private void BtnEquals_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddNumberToDict()
        {
            _DictCounter++;
            _DictAllInputNumbers.Add(_DictCounter, _IntInputNumber);
            _IntInputNumber = new Queue<int>();
        }
        private void GetLastOperator()
        {

        }
    }
}

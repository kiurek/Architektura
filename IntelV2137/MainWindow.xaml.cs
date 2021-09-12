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
using System.Runtime;

namespace IntelV2137
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public char[] memory;
        public Stack<string> processorStack;
        int stackCounter;
        public MainWindow()
        {
            InitializeComponent();
            memory = new char[131072];
            ClearMemory();
            processorStack = new Stack<string>();
            stackCounter = 0;
        }

        private void XCHbtn_Click(object sender, RoutedEventArgs e)
        {
            if (bool.Parse(RadioAXLeft.IsChecked.ToString()))
            {
                if (bool.Parse(RadioAXRight.IsChecked.ToString()))
                {
                    string tmp = AX.Text;
                    AX.Text = AX.Text;
                    AX.Text = tmp;
                }
                else if(bool.Parse(RadioBXRight.IsChecked.ToString()))
                {
                    string tmp = AX.Text;
                    AX.Text = BX.Text;
                    BX.Text = tmp;
                }
                else if (bool.Parse(RadioCXRight.IsChecked.ToString()))
                {
                    string tmp = AX.Text;
                    AX.Text = CX.Text;
                    CX.Text = tmp;
                }
                else if (bool.Parse(RadioDXRight.IsChecked.ToString()))
                {
                    string tmp = AX.Text;
                    AX.Text = DX.Text;
                    DX.Text = tmp;
                }
            } 
            else if (bool.Parse(RadioBXLeft.IsChecked.ToString()))
            {
                if (bool.Parse(RadioAXRight.IsChecked.ToString()))
                {
                    string tmp = BX.Text;
                    BX.Text = AX.Text;
                    AX.Text = tmp;
                }
                else if (bool.Parse(RadioBXRight.IsChecked.ToString()))
                {
                    string tmp = BX.Text;
                    BX.Text = BX.Text;
                    BX.Text = tmp;
                }
                else if (bool.Parse(RadioCXRight.IsChecked.ToString()))
                {
                    string tmp = BX.Text;
                    BX.Text = CX.Text;
                    CX.Text = tmp;
                }
                else if (bool.Parse(RadioDXRight.IsChecked.ToString()))
                {
                    string tmp = BX.Text;
                    BX.Text = DX.Text;
                    DX.Text = tmp;
                }
            } 
            else if (bool.Parse(RadioCXLeft.IsChecked.ToString()))
            {
                if (bool.Parse(RadioAXRight.IsChecked.ToString()))
                {
                    string tmp = CX.Text;
                    CX.Text = AX.Text;
                    AX.Text = tmp;
                }
                else if (bool.Parse(RadioBXRight.IsChecked.ToString()))
                {
                    string tmp = CX.Text;
                    CX.Text = BX.Text;
                    BX.Text = tmp;
                }
                else if (bool.Parse(RadioCXRight.IsChecked.ToString()))
                {
                    string tmp = CX.Text;
                    CX.Text = CX.Text;
                    CX.Text = tmp;
                }
                else if (bool.Parse(RadioDXRight.IsChecked.ToString()))
                {
                    string tmp = CX.Text;
                    CX.Text = DX.Text;
                    DX.Text = tmp;
                }
            } 
            else if (bool.Parse(RadioDXLeft.IsChecked.ToString()))
            {
                if (bool.Parse(RadioAXRight.IsChecked.ToString()))
                {
                    string tmp = DX.Text;
                    DX.Text = AX.Text;
                    AX.Text = tmp;
                }
                else if (bool.Parse(RadioBXRight.IsChecked.ToString()))
                {
                    string tmp = DX.Text;
                    DX.Text = BX.Text;
                    BX.Text = tmp;
                }
                else if (bool.Parse(RadioCXRight.IsChecked.ToString()))
                {
                    string tmp = DX.Text;
                    DX.Text = CX.Text;
                    CX.Text = tmp;
                }
                else if (bool.Parse(RadioDXRight.IsChecked.ToString()))
                {
                    string tmp = DX.Text;
                    DX.Text = DX.Text;
                    DX.Text = tmp;
                }
            }
        }

        private void MOVbtn_Click(object sender, RoutedEventArgs e)
        {
            if (bool.Parse(RadioAXLeft.IsChecked.ToString()))
            {
                if (bool.Parse(RadioAXRight.IsChecked.ToString()))
                {
                    AX.Text = AX.Text;
                }
                else if (bool.Parse(RadioBXRight.IsChecked.ToString()))
                {
                    AX.Text = BX.Text;
                }
                else if (bool.Parse(RadioCXRight.IsChecked.ToString()))
                {
                    AX.Text = CX.Text;
                }
                else if (bool.Parse(RadioDXRight.IsChecked.ToString()))
                {
                    AX.Text = DX.Text;
                }
            }
            else if (bool.Parse(RadioBXLeft.IsChecked.ToString()))
            {
                if (bool.Parse(RadioAXRight.IsChecked.ToString()))
                {
                    BX.Text = AX.Text;
                }
                else if (bool.Parse(RadioBXRight.IsChecked.ToString()))
                {
                    BX.Text = BX.Text;
                }
                else if (bool.Parse(RadioCXRight.IsChecked.ToString()))
                {
                    BX.Text = CX.Text;
                }
                else if (bool.Parse(RadioDXRight.IsChecked.ToString()))
                {
                    BX.Text = DX.Text;
                }
            }
            else if (bool.Parse(RadioCXLeft.IsChecked.ToString()))
            {
                if (bool.Parse(RadioAXRight.IsChecked.ToString()))
                {
                    CX.Text = AX.Text;
                }
                else if (bool.Parse(RadioBXRight.IsChecked.ToString()))
                {
                    CX.Text = BX.Text;
                }
                else if (bool.Parse(RadioCXRight.IsChecked.ToString()))
                {
                    CX.Text = CX.Text;
                }
                else if (bool.Parse(RadioDXRight.IsChecked.ToString()))
                {
                    CX.Text = DX.Text;
                }
            }
            else if (bool.Parse(RadioDXLeft.IsChecked.ToString()))
            {
                if (bool.Parse(RadioAXRight.IsChecked.ToString()))
                {
                    DX.Text = AX.Text;
                }
                else if (bool.Parse(RadioBXRight.IsChecked.ToString()))
                {
                    DX.Text = BX.Text;
                }
                else if (bool.Parse(RadioCXRight.IsChecked.ToString()))
                {
                    DX.Text = CX.Text;
                }
                else if (bool.Parse(RadioDXRight.IsChecked.ToString()))
                {
                    DX.Text = DX.Text;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (bool.Parse(RadioAXLeft.IsChecked.ToString()))
            {
                string tmp = TextBoxValue.Text.ToUpper();
                AX.Text = tmp;
            }
            else if (bool.Parse(RadioBXLeft.IsChecked.ToString()))
            {
                string tmp = TextBoxValue.Text.ToUpper();
                BX.Text = tmp;
            }
            else if (bool.Parse(RadioCXLeft.IsChecked.ToString()))
            {
                string tmp = TextBoxValue.Text.ToUpper();
                CX.Text = tmp;
            }
            else if (bool.Parse(RadioDXLeft.IsChecked.ToString()))
            {
                string tmp = TextBoxValue.Text.ToUpper();
                DX.Text = tmp;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AX.Text = "0000";
            BX.Text = "0000";
            CX.Text = "0000";
            DX.Text = "0000";
            SI.Text = "0000";
            DI.Text = "0000";
            BP.Text = "0000";
            DISP.Text = "0000";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();
            AX.Text = rand.Next(0, 65535).ToString("X");
            AddZeros(AX.Text, AX);
            BX.Text = rand.Next(0, 65535).ToString("X");
            AddZeros(BX.Text, BX);
            CX.Text = rand.Next(0, 65535).ToString("X");
            AddZeros(CX.Text, CX);
            DX.Text = rand.Next(0, 65535).ToString("X");
            AddZeros(DX.Text, DX);
            SI.Text = rand.Next(0, 65535).ToString("X");
            AddZeros(SI.Text, SI);
            DI.Text = rand.Next(0, 65535).ToString("X");
            AddZeros(DI.Text, DI);
            BP.Text = rand.Next(0, 65535).ToString("X");
            AddZeros(BP.Text, BP);
            DISP.Text = rand.Next(0, 65535).ToString("X");
            AddZeros(DISP.Text, DISP);

        }
        void AddZeros(string hex, TextBlock block)
        {
            if (hex.Length<4)
            {
                string x = "0";
                x += hex;
                hex = x;
                block.Text = hex;
                AddZeros(hex, block);
            }
        }
        public void ClearMemory()
        {
            for (int i = 0; i < memory.Length; i++)
            {
                memory[i] = '0';
            }
        }
        public void ClearStack()
        {
            processorStack.Clear();
        }

        private void MemoryClearBtn_Click(object sender, RoutedEventArgs e)
        {
            ClearMemory();
        }

        private void PushBtn_Click(object sender, RoutedEventArgs e)
        {
            if (bool.Parse(RadioAX.IsChecked.ToString()))
            {
                processorStack.Push(AX.Text);
                stackCounter++;
                SP.Text = (stackCounter * 2).ToString("X");
                AddZeros(SP.Text, SP);
            }
            else if (bool.Parse(RadioBX.IsChecked.ToString()))
            {
                processorStack.Push(BX.Text);
                stackCounter++;
                SP.Text = (stackCounter * 2).ToString("X");
                AddZeros(SP.Text, SP);
            }
            else if (bool.Parse(RadioCX.IsChecked.ToString()))
            {
                processorStack.Push(CX.Text);
                stackCounter++;
                SP.Text = (stackCounter * 2).ToString("X");
                AddZeros(SP.Text, SP);
            }
            else if (bool.Parse(RadioDX.IsChecked.ToString()))
            {
                processorStack.Push(DX.Text);
                stackCounter++;
                SP.Text = (stackCounter * 2).ToString("X");
                AddZeros(SP.Text, SP);
            }
        }

        private void PopBtn_Click(object sender, RoutedEventArgs e)
        {
            if (stackCounter>0)
            {
                if (bool.Parse(RadioAX.IsChecked.ToString()))
                {
                    AX.Text = processorStack.Pop();
                    stackCounter--;
                    SP.Text = (stackCounter * 2).ToString("X");
                    AddZeros(SP.Text, SP);
                }
                else if (bool.Parse(RadioBX.IsChecked.ToString()))
                {
                    BX.Text = processorStack.Pop();
                    stackCounter--;
                    SP.Text = (stackCounter * 2).ToString("X");
                    AddZeros(SP.Text, SP);
                }
                else if (bool.Parse(RadioCX.IsChecked.ToString()))
                {
                    CX.Text = processorStack.Pop();
                    stackCounter--;
                    SP.Text = (stackCounter * 2).ToString("X");
                    AddZeros(SP.Text, SP);
                }
                else if (bool.Parse(RadioDX.IsChecked.ToString()))
                {
                    DX.Text = processorStack.Pop();
                    stackCounter--;
                    SP.Text = (stackCounter * 2).ToString("X");
                    AddZeros(SP.Text, SP);
                } 
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ClearStack();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioSIMemory.IsEnabled = true;
            RadioDIMemory.IsEnabled = true;
            RadioBXBase.IsChecked = false;
            RadioBPBase.IsChecked = false;
            RadioSIBXMemory.IsChecked = false;
            RadioDIBXMemory.IsChecked = false;
            RadioSIBPMemory.IsChecked = false;
            RadioDIBPMemory.IsChecked = false;
            RadioBXBase.IsEnabled = false;
            RadioBPBase.IsEnabled = false;
            RadioSIBXMemory.IsEnabled = false;
            RadioDIBXMemory.IsEnabled = false;
            RadioSIBPMemory.IsEnabled = false;
            RadioDIBPMemory.IsEnabled = false;
        }

        private void RadioBase_Checked(object sender, RoutedEventArgs e)
        {
            RadioBXBase.IsEnabled = true;
            RadioBPBase.IsEnabled = true;
            RadioSIMemory.IsChecked = false;
            RadioDIMemory.IsChecked = false;
            RadioSIBXMemory.IsChecked = false;
            RadioDIBXMemory.IsChecked = false;
            RadioSIBPMemory.IsChecked = false;
            RadioDIBPMemory.IsChecked = false;
            RadioSIMemory.IsEnabled = false;
            RadioDIMemory.IsEnabled = false;
            RadioSIBXMemory.IsEnabled = false;
            RadioDIBXMemory.IsEnabled = false;
            RadioSIBPMemory.IsEnabled = false;
            RadioDIBPMemory.IsEnabled = false;
        }

        private void RadioIndexBase_Checked(object sender, RoutedEventArgs e)
        {
            RadioSIBXMemory.IsEnabled = true;
            RadioDIBXMemory.IsEnabled = true;
            RadioSIBPMemory.IsEnabled = true;
            RadioDIBPMemory.IsEnabled = true;
            RadioSIMemory.IsChecked = false;
            RadioDIMemory.IsChecked = false;
            RadioBXBase.IsChecked = false;
            RadioBPBase.IsChecked = false;
            RadioSIMemory.IsEnabled = false;
            RadioDIMemory.IsEnabled = false;
            RadioBXBase.IsEnabled = false;
            RadioBPBase.IsEnabled = false;
        }

        private void MOVMemoryBtn_Click(object sender, RoutedEventArgs e)
        {
            int disp = int.Parse(DISP.Text, System.Globalization.NumberStyles.HexNumber);
            int si = int.Parse(SI.Text, System.Globalization.NumberStyles.HexNumber);
            int di = int.Parse(DI.Text, System.Globalization.NumberStyles.HexNumber);
            int bp = int.Parse(BP.Text, System.Globalization.NumberStyles.HexNumber);
            int bx = int.Parse(BX.Text, System.Globalization.NumberStyles.HexNumber);

            if (bool.Parse(RadioIndex.IsChecked.ToString()))
            {
                if (bool.Parse(RadioSTMBtn.IsChecked.ToString()))
                {
                    if (bool.Parse(RadioSIMemory.IsChecked.ToString()))
                    {
                        if (si+disp<memory.Length)
                        {
                            if (bool.Parse(RadioAXMemory.IsChecked.ToString()))
                            {
                                var tmp = AX.Text.ToCharArray();
                                int j = 0;
                                for (int i = disp + si; i < disp + si + 4; i++)
                                {
                                    memory[i] = tmp[j];
                                    j++;
                                }
                            }
                            else if (bool.Parse(RadioBXMemory.IsChecked.ToString()))
                            {
                                var tmp = BX.Text.ToCharArray();
                                int j = 0;
                                for (int i = disp + si; i < disp + si + 4; i++)
                                {
                                    memory[i] = tmp[j];
                                    j++;
                                }
                            }
                            else if (bool.Parse(RadioCXMemory.IsChecked.ToString()))
                            {
                                var tmp = CX.Text.ToCharArray();
                                int j = 0;
                                for (int i = disp + si; i < disp + si + 4; i++)
                                {
                                    memory[i] = tmp[j];
                                    j++;
                                }
                            }
                            else if (bool.Parse(RadioDXMemory.IsChecked.ToString()))
                            {
                                var tmp = DX.Text.ToCharArray();
                                int j = 0;
                                for (int i = disp + si; i < disp + si + 4; i++)
                                {
                                    memory[i] = tmp[j];
                                    j++;
                                }
                            } 
                        }
                    }
                    else if (bool.Parse(RadioDIMemory.IsChecked.ToString()))
                    {
                        if (di+disp<memory.Length)
                        {
                            if (bool.Parse(RadioAXMemory.IsChecked.ToString()))
                            {
                                var tmp = AX.Text.ToCharArray();
                                int j = 0;
                                for (int i = disp + di; i < disp + di + 4; i++)
                                {
                                    memory[i] = tmp[j];
                                    j++;
                                }
                            }
                            else if (bool.Parse(RadioBXMemory.IsChecked.ToString()))
                            {
                                var tmp = BX.Text.ToCharArray();
                                int j = 0;
                                for (int i = disp + di; i < disp + di + 4; i++)
                                {
                                    memory[i] = tmp[j];
                                    j++;
                                }
                            }
                            else if (bool.Parse(RadioCXMemory.IsChecked.ToString()))
                            {
                                var tmp = CX.Text.ToCharArray();
                                int j = 0;
                                for (int i = disp + di; i < disp + di + 4; i++)
                                {
                                    memory[i] = tmp[j];
                                    j++;
                                }
                            }
                            else if (bool.Parse(RadioDXMemory.IsChecked.ToString()))
                            {
                                var tmp = DX.Text.ToCharArray();
                                int j = 0;
                                for (int i = disp + di; i < disp + di + 4; i++)
                                {
                                    memory[i] = tmp[j];
                                    j++;
                                }
                            } 
                        }
                    }
                }
                else if (bool.Parse(RadioMTSBtn.IsChecked.ToString()))
                {
                    if (bool.Parse(RadioSIMemory.IsChecked.ToString()))
                    {
                        if (si+disp<memory.Length)
                        {
                            if (bool.Parse(RadioAXMemory.IsChecked.ToString()))
                            {
                                string tmp = "";
                                for (int i = disp + si; i < disp + si + 4; i++)
                                {
                                    tmp += memory[i].ToString();
                                }
                                AX.Text = tmp;
                            }
                            else if (bool.Parse(RadioBXMemory.IsChecked.ToString()))
                            {
                                string tmp = "";
                                for (int i = disp + si; i < disp + si + 4; i++)
                                {
                                    tmp += memory[i].ToString();
                                }
                                BX.Text = tmp;
                            }
                            else if (bool.Parse(RadioCXMemory.IsChecked.ToString()))
                            {
                                string tmp = "";
                                for (int i = disp + si; i < disp + si + 4; i++)
                                {
                                    tmp += memory[i].ToString();
                                }
                                CX.Text = tmp;
                            }
                            else if (bool.Parse(RadioDXMemory.IsChecked.ToString()))
                            {
                                string tmp = "";
                                for (int i = disp + si; i < disp + si + 4; i++)
                                {
                                    tmp += memory[i].ToString();
                                }
                                DX.Text = tmp;
                            } 
                        }
                    }
                    else if (bool.Parse(RadioDIMemory.IsChecked.ToString()))
                    {
                        if (di + disp < memory.Length)
                        {
                            if (bool.Parse(RadioAXMemory.IsChecked.ToString()))
                            {
                                string tmp = "";
                                for (int i = disp + di; i < disp + di + 4; i++)
                                {
                                    tmp += memory[i].ToString();
                                }
                                AX.Text = tmp;
                            }
                            else if (bool.Parse(RadioBXMemory.IsChecked.ToString()))
                            {
                                string tmp = "";
                                for (int i = disp + di; i < disp + di + 4; i++)
                                {
                                    tmp += memory[i].ToString();
                                }
                                BX.Text = tmp;
                            }
                            else if (bool.Parse(RadioCXMemory.IsChecked.ToString()))
                            {
                                string tmp = "";
                                for (int i = disp + di; i < disp + di + 4; i++)
                                {
                                    tmp += memory[i].ToString();
                                }
                                CX.Text = tmp;
                            }
                            else if (bool.Parse(RadioDXMemory.IsChecked.ToString()))
                            {
                                string tmp = "";
                                for (int i = disp + di; i < disp + di + 4; i++)
                                {
                                    tmp += memory[i].ToString();
                                }
                                DX.Text = tmp;
                            } 
                        }
                    }
                }
            }
            else if (bool.Parse(RadioBase.IsChecked.ToString()))
            {
                if (bool.Parse(RadioSTMBtn.IsChecked.ToString()))
                {
                    if (bool.Parse(RadioBXBase.IsChecked.ToString()))
                    {
                        if (bx + disp < memory.Length)
                        {
                            if (bool.Parse(RadioAXMemory.IsChecked.ToString()))
                            {
                                var tmp = AX.Text.ToCharArray();
                                int j = 0;
                                for (int i = disp + bx; i < disp + bx + 4; i++)
                                {
                                    memory[i] = tmp[j];
                                    j++;
                                }
                            }
                            else if (bool.Parse(RadioBXMemory.IsChecked.ToString()))
                            {
                                var tmp = BX.Text.ToCharArray();
                                int j = 0;
                                for (int i = disp + bx; i < disp + bx + 4; i++)
                                {
                                    memory[i] = tmp[j];
                                    j++;
                                }
                            }
                            else if (bool.Parse(RadioCXMemory.IsChecked.ToString()))
                            {
                                var tmp = CX.Text.ToCharArray();
                                int j = 0;
                                for (int i = disp + bx; i < disp + bx + 4; i++)
                                {
                                    memory[i] = tmp[j];
                                    j++;
                                }
                            }
                            else if (bool.Parse(RadioDXMemory.IsChecked.ToString()))
                            {
                                var tmp = DX.Text.ToCharArray();
                                int j = 0;
                                for (int i = disp + bx; i < disp + bx + 4; i++)
                                {
                                    memory[i] = tmp[j];
                                    j++;
                                }
                            } 
                        }
                    }
                    else if (bool.Parse(RadioBPBase.IsChecked.ToString()))
                    {
                        if (bp + disp < memory.Length)
                        {
                            if (bool.Parse(RadioAXMemory.IsChecked.ToString()))
                            {
                                var tmp = AX.Text.ToCharArray();
                                int j = 0;
                                for (int i = disp + bp; i < disp + bp + 4; i++)
                                {
                                    memory[i] = tmp[j];
                                    j++;
                                }
                            }
                            else if (bool.Parse(RadioBXMemory.IsChecked.ToString()))
                            {
                                var tmp = BX.Text.ToCharArray();
                                int j = 0;
                                for (int i = disp + bp; i < disp + bp + 4; i++)
                                {
                                    memory[i] = tmp[j];
                                    j++;
                                }
                            }
                            else if (bool.Parse(RadioCXMemory.IsChecked.ToString()))
                            {
                                var tmp = CX.Text.ToCharArray();
                                int j = 0;
                                for (int i = disp + bp; i < disp + bp + 4; i++)
                                {
                                    memory[i] = tmp[j];
                                    j++;
                                }
                            }
                            else if (bool.Parse(RadioDXMemory.IsChecked.ToString()))
                            {
                                var tmp = DX.Text.ToCharArray();
                                int j = 0;
                                for (int i = disp + bp; i < disp + bp + 4; i++)
                                {
                                    memory[i] = tmp[j];
                                    j++;
                                }
                            } 
                        }
                    }
                }
                else if (bool.Parse(RadioMTSBtn.IsChecked.ToString()))
                {
                    if (bool.Parse(RadioBXBase.IsChecked.ToString()))
                    {
                        if (bx + disp < memory.Length)
                        {
                            if (bool.Parse(RadioAXMemory.IsChecked.ToString()))
                            {
                                string tmp = "";
                                for (int i = disp + bx; i < disp + bx + 4; i++)
                                {
                                    tmp += memory[i].ToString();
                                }
                                AX.Text = tmp;
                            }
                            else if (bool.Parse(RadioBXMemory.IsChecked.ToString()))
                            {
                                string tmp = "";
                                for (int i = disp + bx; i < disp + bx + 4; i++)
                                {
                                    tmp += memory[i].ToString();
                                }
                                BX.Text = tmp;
                            }
                            else if (bool.Parse(RadioCXMemory.IsChecked.ToString()))
                            {
                                string tmp = "";
                                for (int i = disp + bx; i < disp + bx + 4; i++)
                                {
                                    tmp += memory[i].ToString();
                                }
                                CX.Text = tmp;
                            }
                            else if (bool.Parse(RadioDXMemory.IsChecked.ToString()))
                            {
                                string tmp = "";
                                for (int i = disp + bx; i < disp + bx + 4; i++)
                                {
                                    tmp += memory[i].ToString();
                                }
                                DX.Text = tmp;
                            } 
                        }
                    }
                    else if (bool.Parse(RadioBPBase.IsChecked.ToString()))
                    {
                        if (bp + disp < memory.Length)
                        {
                            if (bool.Parse(RadioAXMemory.IsChecked.ToString()))
                            {
                                string tmp = "";
                                for (int i = disp + bp; i < disp + bp + 4; i++)
                                {
                                    tmp += memory[i].ToString();
                                }
                                AX.Text = tmp;
                            }
                            else if (bool.Parse(RadioBXMemory.IsChecked.ToString()))
                            {
                                string tmp = "";
                                for (int i = disp + bp; i < disp + bp + 4; i++)
                                {
                                    tmp += memory[i].ToString();
                                }
                                BX.Text = tmp;
                            }
                            else if (bool.Parse(RadioCXMemory.IsChecked.ToString()))
                            {
                                string tmp = "";
                                for (int i = disp + bp; i < disp + bp + 4; i++)
                                {
                                    tmp += memory[i].ToString();
                                }
                                CX.Text = tmp;
                            }
                            else if (bool.Parse(RadioDXMemory.IsChecked.ToString()))
                            {
                                string tmp = "";
                                for (int i = disp + bp; i < disp + bp + 4; i++)
                                {
                                    tmp += memory[i].ToString();
                                }
                                DX.Text = tmp;
                            } 
                        }
                    }
                }
            }
            else if (bool.Parse(RadioIndexBase.IsChecked.ToString()))
            {
                if (bool.Parse(RadioSTMBtn.IsChecked.ToString()))
                {
                    if (bool.Parse(RadioSIBXMemory.IsChecked.ToString()))
                    {
                        if (si + bx + disp < memory.Length)
                        {
                            if (bool.Parse(RadioAXMemory.IsChecked.ToString()))
                            {
                                var tmp = AX.Text.ToCharArray();
                                int j = 0;
                                for (int i = disp + si + bx; i < disp + si + bx + 4; i++)
                                {
                                    memory[i] = tmp[j];
                                    j++;
                                }
                            }
                            else if (bool.Parse(RadioBXMemory.IsChecked.ToString()))
                            {
                                var tmp = BX.Text.ToCharArray();
                                int j = 0;
                                for (int i = disp + si + bx; i < disp + si + bx + 4; i++)
                                {
                                    memory[i] = tmp[j];
                                    j++;
                                }
                            }
                            else if (bool.Parse(RadioCXMemory.IsChecked.ToString()))
                            {
                                var tmp = CX.Text.ToCharArray();
                                int j = 0;
                                for (int i = disp + si + bx; i < disp + si + bx + 4; i++)
                                {
                                    memory[i] = tmp[j];
                                    j++;
                                }
                            }
                            else if (bool.Parse(RadioDXMemory.IsChecked.ToString()))
                            {
                                var tmp = DX.Text.ToCharArray();
                                int j = 0;
                                for (int i = disp + si + bx; i < disp + si + bx + 4; i++)
                                {
                                    memory[i] = tmp[j];
                                    j++;
                                }
                            } 
                        }
                    }
                    else if (bool.Parse(RadioDIBXMemory.IsChecked.ToString()))
                    {
                        if (di + bx + disp < memory.Length)
                        {
                            if (bool.Parse(RadioAXMemory.IsChecked.ToString()))
                            {
                                var tmp = AX.Text.ToCharArray();
                                int j = 0;
                                for (int i = disp + di + bx; i < disp + di + bx + 4; i++)
                                {
                                    memory[i] = tmp[j];
                                    j++;
                                }
                            }
                            else if (bool.Parse(RadioBXMemory.IsChecked.ToString()))
                            {
                                var tmp = BX.Text.ToCharArray();
                                int j = 0;
                                for (int i = disp + di + bx; i < disp + di + bx + 4; i++)
                                {
                                    memory[i] = tmp[j];
                                    j++;
                                }
                            }
                            else if (bool.Parse(RadioCXMemory.IsChecked.ToString()))
                            {
                                var tmp = CX.Text.ToCharArray();
                                int j = 0;
                                for (int i = disp + di + bx; i < disp + di + bx + 4; i++)
                                {
                                    memory[i] = tmp[j];
                                    j++;
                                }
                            }
                            else if (bool.Parse(RadioDXMemory.IsChecked.ToString()))
                            {
                                var tmp = DX.Text.ToCharArray();
                                int j = 0;
                                for (int i = disp + di + bx; i < disp + di + bx + 4; i++)
                                {
                                    memory[i] = tmp[j];
                                    j++;
                                }
                            } 
                        }
                    }
                    else if (bool.Parse(RadioSIBPMemory.IsChecked.ToString()))
                    {
                        if (si + bp + disp < memory.Length)
                        {
                            if (bool.Parse(RadioAXMemory.IsChecked.ToString()))
                            {
                                var tmp = AX.Text.ToCharArray();
                                int j = 0;
                                for (int i = disp + si + bp; i < disp + si + bp + 4; i++)
                                {
                                    memory[i] = tmp[j];
                                    j++;
                                }
                            }
                            else if (bool.Parse(RadioBXMemory.IsChecked.ToString()))
                            {
                                var tmp = BX.Text.ToCharArray();
                                int j = 0;
                                for (int i = disp + si + bp; i < disp + si + bp + 4; i++)
                                {
                                    memory[i] = tmp[j];
                                    j++;
                                }
                            }
                            else if (bool.Parse(RadioCXMemory.IsChecked.ToString()))
                            {
                                var tmp = CX.Text.ToCharArray();
                                int j = 0;
                                for (int i = disp + si + bp; i < disp + si + bp + 4; i++)
                                {
                                    memory[i] = tmp[j];
                                    j++;
                                }
                            }
                            else if (bool.Parse(RadioDXMemory.IsChecked.ToString()))
                            {
                                var tmp = DX.Text.ToCharArray();
                                int j = 0;
                                for (int i = disp + si + bp; i < disp + si + bp + 4; i++)
                                {
                                    memory[i] = tmp[j];
                                    j++;
                                }
                            } 
                        }
                    }
                    else if (bool.Parse(RadioDIBPMemory.IsChecked.ToString()))
                    {
                        if (di + bp + disp < memory.Length)
                        {
                            if (bool.Parse(RadioAXMemory.IsChecked.ToString()))
                            {
                                var tmp = AX.Text.ToCharArray();
                                int j = 0;
                                for (int i = disp + di + bp; i < disp + di + bp + 4; i++)
                                {
                                    memory[i] = tmp[j];
                                    j++;
                                }
                            }
                            else if (bool.Parse(RadioBXMemory.IsChecked.ToString()))
                            {
                                var tmp = BX.Text.ToCharArray();
                                int j = 0;
                                for (int i = disp + di + bp; i < disp + di + bp + 4; i++)
                                {
                                    memory[i] = tmp[j];
                                    j++;
                                }
                            }
                            else if (bool.Parse(RadioCXMemory.IsChecked.ToString()))
                            {
                                var tmp = CX.Text.ToCharArray();
                                int j = 0;
                                for (int i = disp + di + bp; i < disp + di + bp + 4; i++)
                                {
                                    memory[i] = tmp[j];
                                    j++;
                                }
                            }
                            else if (bool.Parse(RadioDXMemory.IsChecked.ToString()))
                            {
                                var tmp = DX.Text.ToCharArray();
                                int j = 0;
                                for (int i = disp + di + bp; i < disp + di + bp + 4; i++)
                                {
                                    memory[i] = tmp[j];
                                    j++;
                                }
                            } 
                        }
                    }
                }
                else if (bool.Parse(RadioMTSBtn.IsChecked.ToString()))
                {
                    if (bool.Parse(RadioSIBXMemory.IsChecked.ToString()))
                    {
                        if (si + bx + disp < memory.Length)
                        {
                            if (bool.Parse(RadioAXMemory.IsChecked.ToString()))
                            {
                                string tmp = "";
                                for (int i = disp + si + bx; i < disp + si + bx + 4; i++)
                                {
                                    tmp += memory[i].ToString();
                                }
                                AX.Text = tmp;
                            }
                            else if (bool.Parse(RadioBXMemory.IsChecked.ToString()))
                            {
                                string tmp = "";
                                for (int i = disp + si + bx; i < disp + si + bx + 4; i++)
                                {
                                    tmp += memory[i].ToString();
                                }
                                BX.Text = tmp;
                            }
                            else if (bool.Parse(RadioCXMemory.IsChecked.ToString()))
                            {
                                string tmp = "";
                                for (int i = disp + si + bx; i < disp + si + bx + 4; i++)
                                {
                                    tmp += memory[i].ToString();
                                }
                                CX.Text = tmp;
                            }
                            else if (bool.Parse(RadioDXMemory.IsChecked.ToString()))
                            {
                                string tmp = "";
                                for (int i = disp + si + bx; i < disp + si + bx + 4; i++)
                                {
                                    tmp += memory[i].ToString();
                                }
                                DX.Text = tmp;
                            } 
                        }
                    }
                    else if (bool.Parse(RadioDIBXMemory.IsChecked.ToString()))
                    {
                        if (di + bx + disp < memory.Length)
                        {
                            if (bool.Parse(RadioAXMemory.IsChecked.ToString()))
                            {
                                string tmp = "";
                                for (int i = disp + di + bx; i < disp + di + bx + 4; i++)
                                {
                                    tmp += memory[i].ToString();
                                }
                                AX.Text = tmp;
                            }
                            else if (bool.Parse(RadioBXMemory.IsChecked.ToString()))
                            {
                                string tmp = "";
                                for (int i = disp + di + bx; i < disp + di + bx + 4; i++)
                                {
                                    tmp += memory[i].ToString();
                                }
                                BX.Text = tmp;
                            }
                            else if (bool.Parse(RadioCXMemory.IsChecked.ToString()))
                            {
                                string tmp = "";
                                for (int i = disp + di + bx; i < disp + di + bx + 4; i++)
                                {
                                    tmp += memory[i].ToString();
                                }
                                CX.Text = tmp;
                            }
                            else if (bool.Parse(RadioDXMemory.IsChecked.ToString()))
                            {
                                string tmp = "";
                                for (int i = disp + di + bx; i < disp + di + bx + 4; i++)
                                {
                                    tmp += memory[i].ToString();
                                }
                                DX.Text = tmp;
                            } 
                        }
                    }
                    else if (bool.Parse(RadioSIBPMemory.IsChecked.ToString()))
                    {
                        if (si + bp + disp < memory.Length)
                        {
                            if (bool.Parse(RadioAXMemory.IsChecked.ToString()))
                            {
                                string tmp = "";
                                for (int i = disp + si + bp; i < disp + si + bp + 4; i++)
                                {
                                    tmp += memory[i].ToString();
                                }
                                AX.Text = tmp;
                            }
                            else if (bool.Parse(RadioBXMemory.IsChecked.ToString()))
                            {
                                string tmp = "";
                                for (int i = disp + si + bp; i < disp + si + bp + 4; i++)
                                {
                                    tmp += memory[i].ToString();
                                }
                                BX.Text = tmp;
                            }
                            else if (bool.Parse(RadioCXMemory.IsChecked.ToString()))
                            {
                                string tmp = "";
                                for (int i = disp + si + bp; i < disp + si + bp + 4; i++)
                                {
                                    tmp += memory[i].ToString();
                                }
                                CX.Text = tmp;
                            }
                            else if (bool.Parse(RadioDXMemory.IsChecked.ToString()))
                            {
                                string tmp = "";
                                for (int i = disp + si + bp; i < disp + si + bp + 4; i++)
                                {
                                    tmp += memory[i].ToString();
                                }
                                DX.Text = tmp;
                            } 
                        }
                    }
                    else if (bool.Parse(RadioDIBPMemory.IsChecked.ToString()))
                    {
                        if (di + bp + disp < memory.Length)
                        {
                            if (bool.Parse(RadioAXMemory.IsChecked.ToString()))
                            {
                                string tmp = "";
                                for (int i = disp + di + bp; i < disp + di + bp + 4; i++)
                                {
                                    tmp += memory[i].ToString();
                                }
                                AX.Text = tmp;
                            }
                            else if (bool.Parse(RadioBXMemory.IsChecked.ToString()))
                            {
                                string tmp = "";
                                for (int i = disp + di + bp; i < disp + di + bp + 4; i++)
                                {
                                    tmp += memory[i].ToString();
                                }
                                BX.Text = tmp;
                            }
                            else if (bool.Parse(RadioCXMemory.IsChecked.ToString()))
                            {
                                string tmp = "";
                                for (int i = disp + di + bp; i < disp + di + bp + 4; i++)
                                {
                                    tmp += memory[i].ToString();
                                }
                                CX.Text = tmp;
                            }
                            else if (bool.Parse(RadioDXMemory.IsChecked.ToString()))
                            {
                                string tmp = "";
                                for (int i = disp + di + bp; i < disp + di + bp + 4; i++)
                                {
                                    tmp += memory[i].ToString();
                                }
                                DX.Text = tmp;
                            } 
                        }
                    }
                }
            }
        }

        private void SetIndexBtn_Click(object sender, RoutedEventArgs e)
        {
            if (bool.Parse(RadioSI.IsChecked.ToString()))
            {
                string tmp = IndexTextBox.Text.ToUpper();
                SI.Text = tmp;
            }
            else if (bool.Parse(RadioDI.IsChecked.ToString()))
            {
                string tmp = IndexTextBox.Text.ToUpper();
                DI.Text = tmp;
            }
            else if (bool.Parse(RadioBP.IsChecked.ToString()))
            {
                string tmp = IndexTextBox.Text.ToUpper();
                BP.Text = tmp;
            }
            else if (bool.Parse(RadioDISP.IsChecked.ToString()))
            {
                string tmp = IndexTextBox.Text.ToUpper();
                DISP.Text = tmp;
            }
        }

        private void XCHMemoryBtn_Click(object sender, RoutedEventArgs e)
        {
            int disp = int.Parse(DISP.Text, System.Globalization.NumberStyles.HexNumber);
            int si = int.Parse(SI.Text, System.Globalization.NumberStyles.HexNumber);
            int di = int.Parse(DI.Text, System.Globalization.NumberStyles.HexNumber);
            int bp = int.Parse(BP.Text, System.Globalization.NumberStyles.HexNumber);
            int bx = int.Parse(BX.Text, System.Globalization.NumberStyles.HexNumber);

            if (bool.Parse(RadioIndex.IsChecked.ToString()))
            {
                if (bool.Parse(RadioSIMemory.IsChecked.ToString()))
                {
                    if (si + disp < memory.Length)
                    {
                        if (bool.Parse(RadioAXMemory.IsChecked.ToString()))
                        {
                            string x = "";
                            for (int i = disp + si; i < disp + si + 4; i++)
                            {
                                x += memory[i].ToString();
                            }

                            var tmp = AX.Text.ToCharArray();
                            int j = 0;
                            for (int i = disp + si; i < disp + si + 4; i++)
                            {
                                memory[i] = tmp[j];
                                j++;
                            }
                            AX.Text = x;
                        }
                        else if (bool.Parse(RadioBXMemory.IsChecked.ToString()))
                        {
                            string x = "";
                            for (int i = disp + si; i < disp + si + 4; i++)
                            {
                                x += memory[i].ToString();
                            }

                            var tmp = BX.Text.ToCharArray();
                            int j = 0;
                            for (int i = disp + si; i < disp + si + 4; i++)
                            {
                                memory[i] = tmp[j];
                                j++;
                            }
                            BX.Text = x;
                        }
                        else if (bool.Parse(RadioCXMemory.IsChecked.ToString()))
                        {
                            string x = "";
                            for (int i = disp + si; i < disp + si + 4; i++)
                            {
                                x += memory[i].ToString();
                            }

                            var tmp = CX.Text.ToCharArray();
                            int j = 0;
                            for (int i = disp + si; i < disp + si + 4; i++)
                            {
                                memory[i] = tmp[j];
                                j++;
                            }
                            CX.Text = x;
                        }
                        else if (bool.Parse(RadioDXMemory.IsChecked.ToString()))
                        {
                            string x = "";
                            for (int i = disp + si; i < disp + si + 4; i++)
                            {
                                x += memory[i].ToString();
                            }

                            var tmp = DX.Text.ToCharArray();
                            int j = 0;
                            for (int i = disp + si; i < disp + si + 4; i++)
                            {
                                memory[i] = tmp[j];
                                j++;
                            }
                            DX.Text = x;
                        }
                    }
                }
                else if (bool.Parse(RadioDIMemory.IsChecked.ToString()))
                {
                    if (di + disp < memory.Length)
                    {
                        if (bool.Parse(RadioAXMemory.IsChecked.ToString()))
                        {
                            string x = "";
                            for (int i = disp + di; i < disp + di + 4; i++)
                            {
                                x += memory[i].ToString();
                            }

                            var tmp = AX.Text.ToCharArray();
                            int j = 0;
                            for (int i = disp + di; i < disp + di + 4; i++)
                            {
                                memory[i] = tmp[j];
                                j++;
                            }
                            AX.Text = x;
                        }
                        else if (bool.Parse(RadioBXMemory.IsChecked.ToString()))
                        {
                            string x = "";
                            for (int i = disp + di; i < disp + di + 4; i++)
                            {
                                x += memory[i].ToString();
                            }

                            var tmp = BX.Text.ToCharArray();
                            int j = 0;
                            for (int i = disp + di; i < disp + di + 4; i++)
                            {
                                memory[i] = tmp[j];
                                j++;
                            }
                            BX.Text = x;
                        }
                        else if (bool.Parse(RadioCXMemory.IsChecked.ToString()))
                        {
                            string x = "";
                            for (int i = disp + di; i < disp + di + 4; i++)
                            {
                                x += memory[i].ToString();
                            }

                            var tmp = CX.Text.ToCharArray();
                            int j = 0;
                            for (int i = disp + di; i < disp + di + 4; i++)
                            {
                                memory[i] = tmp[j];
                                j++;
                            }
                            CX.Text = x;
                        }
                        else if (bool.Parse(RadioDXMemory.IsChecked.ToString()))
                        {
                            string x = "";
                            for (int i = disp + di; i < disp + di + 4; i++)
                            {
                                x += memory[i].ToString();
                            }

                            var tmp = DX.Text.ToCharArray();
                            int j = 0;
                            for (int i = disp + di; i < disp + di + 4; i++)
                            {
                                memory[i] = tmp[j];
                                j++;
                            }
                            DX.Text = x;
                        }
                    }
                }
            }
            else if (bool.Parse(RadioBase.IsChecked.ToString()))
            {
                if (bool.Parse(RadioBXBase.IsChecked.ToString()))
                {
                    if (bx + disp < memory.Length)
                    {
                        if (bool.Parse(RadioAXMemory.IsChecked.ToString()))
                        {
                            string x = "";
                            for (int i = disp + bx; i < disp + bx + 4; i++)
                            {
                                x += memory[i].ToString();
                            }

                            var tmp = AX.Text.ToCharArray();
                            int j = 0;
                            for (int i = disp + bx; i < disp + bx + 4; i++)
                            {
                                memory[i] = tmp[j];
                                j++;
                            }
                            AX.Text = x;
                        }
                        else if (bool.Parse(RadioBXMemory.IsChecked.ToString()))
                        {
                            string x = "";
                            for (int i = disp + bx; i < disp + bx + 4; i++)
                            {
                                x += memory[i].ToString();
                            }

                            var tmp = BX.Text.ToCharArray();
                            int j = 0;
                            for (int i = disp + bx; i < disp + bx + 4; i++)
                            {
                                memory[i] = tmp[j];
                                j++;
                            }
                            BX.Text = x;
                        }
                        else if (bool.Parse(RadioCXMemory.IsChecked.ToString()))
                        {
                            string x = "";
                            for (int i = disp + bx; i < disp + bx + 4; i++)
                            {
                                x += memory[i].ToString();
                            }

                            var tmp = CX.Text.ToCharArray();
                            int j = 0;
                            for (int i = disp + bx; i < disp + bx + 4; i++)
                            {
                                memory[i] = tmp[j];
                                j++;
                            }
                            CX.Text = x;
                        }
                        else if (bool.Parse(RadioDXMemory.IsChecked.ToString()))
                        {
                            string x = "";
                            for (int i = disp + bx; i < disp + bx + 4; i++)
                            {
                                x += memory[i].ToString();
                            }

                            var tmp = DX.Text.ToCharArray();
                            int j = 0;
                            for (int i = disp + bx; i < disp + bx + 4; i++)
                            {
                                memory[i] = tmp[j];
                                j++;
                            }
                            DX.Text = x;
                        }
                    }
                }
                else if (bool.Parse(RadioBPBase.IsChecked.ToString()))
                {
                    if (bp + disp < memory.Length)
                    {
                        if (bool.Parse(RadioAXMemory.IsChecked.ToString()))
                        {
                            string x = "";
                            for (int i = disp + bp; i < disp + bp + 4; i++)
                            {
                                x += memory[i].ToString();
                            }

                            var tmp = AX.Text.ToCharArray();
                            int j = 0;
                            for (int i = disp + bp; i < disp + bp + 4; i++)
                            {
                                memory[i] = tmp[j];
                                j++;
                            }
                            AX.Text = x;
                        }
                        else if (bool.Parse(RadioBXMemory.IsChecked.ToString()))
                        {
                            string x = "";
                            for (int i = disp + bp; i < disp + bp + 4; i++)
                            {
                                x += memory[i].ToString();
                            }

                            var tmp = BX.Text.ToCharArray();
                            int j = 0;
                            for (int i = disp + bp; i < disp + bp + 4; i++)
                            {
                                memory[i] = tmp[j];
                                j++;
                            }
                            BX.Text = x;
                        }
                        else if (bool.Parse(RadioCXMemory.IsChecked.ToString()))
                        {
                            string x = "";
                            for (int i = disp + bp; i < disp + bp + 4; i++)
                            {
                                x += memory[i].ToString();
                            }

                            var tmp = CX.Text.ToCharArray();
                            int j = 0;
                            for (int i = disp + bp; i < disp + bp + 4; i++)
                            {
                                memory[i] = tmp[j];
                                j++;
                            }
                            CX.Text = x;
                        }
                        else if (bool.Parse(RadioDXMemory.IsChecked.ToString()))
                        {
                            string x = "";
                            for (int i = disp + bp; i < disp + bp + 4; i++)
                            {
                                x += memory[i].ToString();
                            }

                            var tmp = DX.Text.ToCharArray();
                            int j = 0;
                            for (int i = disp + bp; i < disp + bp + 4; i++)
                            {
                                memory[i] = tmp[j];
                                j++;
                            }
                            DX.Text = x;
                        }
                    }
                }
            }
            else if (bool.Parse(RadioIndexBase.IsChecked.ToString()))
            {
                if (bool.Parse(RadioSIBXMemory.IsChecked.ToString()))
                {
                    if (si + bx + disp < memory.Length)
                    {
                        if (bool.Parse(RadioAXMemory.IsChecked.ToString()))
                        {
                            string x = "";
                            for (int i = disp + si + bx; i < disp + si + bx + 4; i++)
                            {
                                x += memory[i].ToString();
                            }

                            var tmp = AX.Text.ToCharArray();
                            int j = 0;
                            for (int i = disp + si + bx; i < disp + si + bx + 4; i++)
                            {
                                memory[i] = tmp[j];
                                j++;
                            }
                            AX.Text = x;
                        }
                        else if (bool.Parse(RadioBXMemory.IsChecked.ToString()))
                        {
                            string x = "";
                            for (int i = disp + si + bx; i < disp + si + bx + 4; i++)
                            {
                                x += memory[i].ToString();
                            }

                            var tmp = BX.Text.ToCharArray();
                            int j = 0;
                            for (int i = disp + si + bx; i < disp + si + bx + 4; i++)
                            {
                                memory[i] = tmp[j];
                                j++;
                            }
                            BX.Text = x;
                        }
                        else if (bool.Parse(RadioCXMemory.IsChecked.ToString()))
                        {
                            string x = "";
                            for (int i = disp + si + bx; i < disp + si + bx + 4; i++)
                            {
                                x += memory[i].ToString();
                            }

                            var tmp = CX.Text.ToCharArray();
                            int j = 0;
                            for (int i = disp + si + bx; i < disp + si + bx + 4; i++)
                            {
                                memory[i] = tmp[j];
                                j++;
                            }
                            CX.Text = x;
                        }
                        else if (bool.Parse(RadioDXMemory.IsChecked.ToString()))
                        {
                            string x = "";
                            for (int i = disp + si + bx; i < disp + si + bx + 4; i++)
                            {
                                x += memory[i].ToString();
                            }

                            var tmp = DX.Text.ToCharArray();
                            int j = 0;
                            for (int i = disp + si + bx; i < disp + si + bx + 4; i++)
                            {
                                memory[i] = tmp[j];
                                j++;
                            }
                            DX.Text = x;
                        }
                    }
                }
                else if (bool.Parse(RadioDIBXMemory.IsChecked.ToString()))
                {
                    if (di + bx + disp < memory.Length)
                    {
                        if (bool.Parse(RadioAXMemory.IsChecked.ToString()))
                        {
                            string x = "";
                            for (int i = disp + di + bx; i < disp + di + bx + 4; i++)
                            {
                                x += memory[i].ToString();
                            }

                            var tmp = AX.Text.ToCharArray();
                            int j = 0;
                            for (int i = disp + di + bx; i < disp + di + bx + 4; i++)
                            {
                                memory[i] = tmp[j];
                                j++;
                            }
                            AX.Text = x;
                        }
                        else if (bool.Parse(RadioBXMemory.IsChecked.ToString()))
                        {
                            string x = "";
                            for (int i = disp + di + bx; i < disp + di + bx + 4; i++)
                            {
                                x += memory[i].ToString();
                            }

                            var tmp = BX.Text.ToCharArray();
                            int j = 0;
                            for (int i = disp + di + bx; i < disp + di + bx + 4; i++)
                            {
                                memory[i] = tmp[j];
                                j++;
                            }
                            BX.Text = x;
                        }
                        else if (bool.Parse(RadioCXMemory.IsChecked.ToString()))
                        {
                            string x = "";
                            for (int i = disp + di + bx; i < disp + di + bx + 4; i++)
                            {
                                x += memory[i].ToString();
                            }

                            var tmp = CX.Text.ToCharArray();
                            int j = 0;
                            for (int i = disp + di + bx; i < disp + di + bx + 4; i++)
                            {
                                memory[i] = tmp[j];
                                j++;
                            }
                            CX.Text = x;
                        }
                        else if (bool.Parse(RadioDXMemory.IsChecked.ToString()))
                        {
                            string x = "";
                            for (int i = disp + di + bx; i < disp + di + bx + 4; i++)
                            {
                                x += memory[i].ToString();
                            }

                            var tmp = DX.Text.ToCharArray();
                            int j = 0;
                            for (int i = disp + di + bx; i < disp + di + bx + 4; i++)
                            {
                                memory[i] = tmp[j];
                                j++;
                            }
                            DX.Text = x;
                        }
                    }
                }
                else if (bool.Parse(RadioSIBPMemory.IsChecked.ToString()))
                {
                    if (si + bp + disp < memory.Length)
                    {
                        if (bool.Parse(RadioAXMemory.IsChecked.ToString()))
                        {
                            string x = "";
                            for (int i = disp + si + bp; i < disp + si + bp + 4; i++)
                            {
                                x += memory[i].ToString();
                            }

                            var tmp = AX.Text.ToCharArray();
                            int j = 0;
                            for (int i = disp + si + bp; i < disp + si + bp + 4; i++)
                            {
                                memory[i] = tmp[j];
                                j++;
                            }
                            AX.Text = x;
                        }
                        else if (bool.Parse(RadioBXMemory.IsChecked.ToString()))
                        {
                            string x = "";
                            for (int i = disp + si + bp; i < disp + si + bp + 4; i++)
                            {
                                x += memory[i].ToString();
                            }

                            var tmp = BX.Text.ToCharArray();
                            int j = 0;
                            for (int i = disp + si + bp; i < disp + si + bp + 4; i++)
                            {
                                memory[i] = tmp[j];
                                j++;
                            }
                            BX.Text = x;
                        }
                        else if (bool.Parse(RadioCXMemory.IsChecked.ToString()))
                        {
                            string x = "";
                            for (int i = disp + si + bp; i < disp + si + bp + 4; i++)
                            {
                                x += memory[i].ToString();
                            }

                            var tmp = CX.Text.ToCharArray();
                            int j = 0;
                            for (int i = disp + si + bp; i < disp + si + bp + 4; i++)
                            {
                                memory[i] = tmp[j];
                                j++;
                            }
                            CX.Text = x;
                        }
                        else if (bool.Parse(RadioDXMemory.IsChecked.ToString()))
                        {
                            string x = "";
                            for (int i = disp + si + bp; i < disp + si + bp + 4; i++)
                            {
                                x += memory[i].ToString();
                            }

                            var tmp = DX.Text.ToCharArray();
                            int j = 0;
                            for (int i = disp + si + bp; i < disp + si + bp + 4; i++)
                            {
                                memory[i] = tmp[j];
                                j++;
                            }
                            DX.Text = x;
                        }
                    }
                }
                else if (bool.Parse(RadioDIBPMemory.IsChecked.ToString()))
                {
                    if (di + bp + disp < memory.Length)
                    {
                        if (bool.Parse(RadioAXMemory.IsChecked.ToString()))
                        {
                            string x = "";
                            for (int i = disp + di + bp; i < disp + di + bp + 4; i++)
                            {
                                x += memory[i].ToString();
                            }

                            var tmp = AX.Text.ToCharArray();
                            int j = 0;
                            for (int i = disp + di + bp; i < disp + di + bp + 4; i++)
                            {
                                memory[i] = tmp[j];
                                j++;
                            }
                            AX.Text = x;
                        }
                        else if (bool.Parse(RadioBXMemory.IsChecked.ToString()))
                        {
                            string x = "";
                            for (int i = disp + di + bp; i < disp + di + bp + 4; i++)
                            {
                                x += memory[i].ToString();
                            }

                            var tmp = BX.Text.ToCharArray();
                            int j = 0;
                            for (int i = disp + di + bp; i < disp + di + bp + 4; i++)
                            {
                                memory[i] = tmp[j];
                                j++;
                            }
                            BX.Text = x;
                        }
                        else if (bool.Parse(RadioCXMemory.IsChecked.ToString()))
                        {
                            string x = "";
                            for (int i = disp + di + bp; i < disp + di + bp + 4; i++)
                            {
                                x += memory[i].ToString();
                            }

                            var tmp = CX.Text.ToCharArray();
                            int j = 0;
                            for (int i = disp + di + bp; i < disp + di + bp + 4; i++)
                            {
                                memory[i] = tmp[j];
                                j++;
                            }
                            CX.Text = x;
                        }
                        else if (bool.Parse(RadioDXMemory.IsChecked.ToString()))
                        {
                            string x = "";
                            for (int i = disp + di + bp; i < disp + di + bp + 4; i++)
                            {
                                x += memory[i].ToString();
                            }

                            var tmp = DX.Text.ToCharArray();
                            int j = 0;
                            for (int i = disp + di + bp; i < disp + di + bp + 4; i++)
                            {
                                memory[i] = tmp[j];
                                j++;
                            }
                            DX.Text = x;
                        }
                    }
                }
            }
        }

        private void RadioDISP_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}

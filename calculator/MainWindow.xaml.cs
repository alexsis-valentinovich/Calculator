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

namespace calculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// 
    /// 
    /// 
    /// По событию "нажатие кнопки", в текстбокс 'Expression' добавляется определенный символ
    /// По событию "нажатие кнопки равно Button_Click_16" происходит вычисление

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Decision.Text = "Ответ: ";
        }
        private void Button_Click(object sender, RoutedEventArgs e)  // вводим в текстбокс Expression символ "1".
                                                                     // Содержимое тексбокса не удаляем.
        {
            Expression.Text += "1";

        }

        private void Button_Click_1(object sender, RoutedEventArgs e) // вводим в текстбокс Expression символ "2".
                                                                      // Содержимое тексбокса не удаляем
        {
            Expression.Text += "2";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)// вводим в текстбокс Expression символ "3".
                                                                     // Содержимое тексбокса не удаляем
        {
            Expression.Text += "3";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)// вводим в текстбокс Expression символ "4".
                                                                     // Содержимое тексбокса не удаляем
        {
            Expression.Text += "4";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)// вводим в текстбокс Expression символ "5".
                                                                     // Содержимое тексбокса не удаляем
        {
            Expression.Text += "5";
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)// вводим в текстбокс Expression символ "6".
                                                                     // Содержимое тексбокса не удаляем
        {
            Expression.Text += "6";
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)// вводим в текстбокс Expression символ "7".
                                                                     // Содержимое тексбокса не удаляем
        {
            Expression.Text += "7";
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)// вводим в текстбокс Expression символ "8".
                                                                     // Содержимое тексбокса не удаляем
        {
            Expression.Text += "8";
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)// вводим в текстбокс Expression символ "9".
                                                                     // Содержимое тексбокса не удаляем
        {
            Expression.Text += "9";
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)// вводим в текстбокс Expression символ "0".
                                                                     // Содержимое тексбокса не удаляем
        {
            Expression.Text += "0";
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)// вводим в текстбокс Expression символ "+".
                                                                      // Содержимое тексбокса не удаляем
        {
            Expression.Text += "+";
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)// вводим в текстбокс Expression символ "-".
                                                                      // Содержимое тексбокса не удаляем
        {
            Expression.Text += "-";
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)// вводим в текстбокс Expression символ "*".
                                                                      // Содержимое тексбокса не удаляем
        {
            Expression.Text += "*";
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)// вводим в текстбокс Expression символ "/".
                                                                      // Содержимое тексбокса не удаляем
        {
            Expression.Text += "/";
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)// вводим в текстбокс Expression символ "(".
                                                                      // Содержимое тексбокса не удаляем
        {
            Expression.Text += "(";
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)// вводим в текстбокс Expression символ ")".
                                                                      // Содержимое тексбокса не удаляем
        {
            Expression.Text += ")";
        }

        private void Button_Click_17(object sender, RoutedEventArgs e)// удаляем последний символ.
        {
            Expression.Text = Expression.Text.Substring(0, Expression.Text.Length - 1);
        }

        private void Button_Click_18(object sender, RoutedEventArgs e)// очищаем весь текстбокс.
        {
            Expression.Clear();
        }
        private void Button_Click_19(object sender, RoutedEventArgs e)// вводим в текстбокс Expression символ ".".
                                                                      // Содержимое тексбокса не удаляем
        {
            Expression.Text += ",";
        }
        private void Button_Click_20(object sender, RoutedEventArgs e)   // Помощь
        {
            popup_Help.IsOpen = true;
        }
        private void Button_Click_21(object sender, RoutedEventArgs e)   // Выход
        {
            this.Close();
        }
        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            {
                string str_Expression = "(" + Expression.Text + ")"; ;

                char[] sing_Arif_Sk = { '(', ')' };                           // скобки
                char[] sing_Arif_Sum = { '+', '-' };                          // сумма и разность
                char[] sing_Arif_Div = { '*', '/' };                          // умножение и деление

                int position_Skobka = str_Expression.IndexOfAny(sing_Arif_Sk);// позиция скобок в выражении
                //    string str_Action исследуемая строка. Выделяем арифметические выражения  в строке, вычисляем
                //    и заменяем в первоначальной строке выделенную часть результатом вычисления. Вычисление и выделение слагаемых из основного выражения
                //    происходит по правилам арифметики. Первым выделяется выражение в скобках, затем умножение и деление, затем сложение и вычитание.
                string str_Action = str_Expression;
                int Flag = 0;
                if (Check(str_Action) == false)
                {
                    Flag = 0;
                }
                else
                {
                    Flag = 1;
                }

                while (position_Skobka != -1 && Flag == 1)
                {
                    str_Action = str_Expression;
                    int i = 0;
                    int j = 0;
                    int position_Skobka_1 = 0;                    // позиция открывающей скобки '('
                    int position_Skobka_2 = 0;                    // позиция открывающей скобки ')'

                    foreach (char c in str_Action)
                    {
                        if (c == '(' || c == ')')
                        {
                            if (i < 1 && c == '(')
                            {
                                position_Skobka_1 = j;            // позиция открывающей скобки '('

                            }
                            else
                            {
                                if (i < 1 || c == ')')
                                {
                                    position_Skobka_2 = j;        // позиция открывающей скобки ')'
                                    i = 1;
                                }
                            }
                        }
                        j++;
                        if (i == 1)
                        {
                            break;
                        }
                    }

                    str_Action = str_Action.Substring(position_Skobka_1 + 1, position_Skobka_2 - position_Skobka_1 - 1);   // получаем выражение, находящееся внутри скобок

                    //-----------     начало                                                                   --------------
                    //-----------     цель. вычисляем произведениеи частное и вставляем виследуемую строку     --------------
                    //-----------     и частное и вставляем виследуемую строку. получаем строку в которой      --------------
                    //-----------     нет умножения и деления, только сложение и разность. Вычисление          --------------
                    //-----------     в методе произведения и разности string Division(string stroka)          --------------
                    int position_Mu_Di = str_Action.IndexOfAny(sing_Arif_Sum);             // избавляемся от + и -. получаем строку только с * и /.
                    int position_Add_Sub = str_Action.IndexOfAny(sing_Arif_Div);           // и производим действие и заменяем элемент на результат

                    string str_Part_1 = "";                                                // левая часть от первого + или -
                    while (position_Add_Sub != -1)                                         // делайм действие пока находим знак * и /
                    {
                        position_Mu_Di = str_Action.IndexOfAny(sing_Arif_Sum);             // определяем позицию + или -
                        if (position_Mu_Di != -1)
                        {
                            str_Part_1 = str_Action.Substring(0, position_Mu_Di);          // выделяем левую часть от первого + или -
                        }
                        else
                        {
                            str_Part_1 = str_Action;                                       // если не было + или - присваиваем к левой части иследуемую строку
                        }
                        position_Add_Sub = str_Part_1.IndexOfAny(sing_Arif_Div);           // проверка на наличие знак * и /
                        if (position_Add_Sub != -1)                                        // если нет знак * и /, то не вычисляем
                        {
                            string rezult_D = Division(str_Part_1);                        // вычисляем произведение или частное
                            if (position_Mu_Di == -1)
                            {
                                str_Part_1 = "(" + str_Part_1 + ")";
                            }
                            str_Expression = str_Expression.Replace(str_Part_1, rezult_D); // заменяем иследуемую часть строки на  произведение или частное
                        }
                        string str_Part_2 = str_Action.Substring(position_Mu_Di + 1, str_Action.Length - position_Mu_Di - 1);// выделяем правую часть от первого + или -
                        int pos_Sing_V1 = str_Part_2.IndexOfAny(sing_Arif_Sum);             // проверка на наличие знак + и -
                        int pos_Sing_D1 = str_Part_2.IndexOfAny(sing_Arif_Div);             // проверка на наличие знак * и /
                        if (pos_Sing_V1 == -1 && pos_Sing_D1 != -1)
                        {
                            string rezult_D = Division(str_Part_2);                          // вычисляем произведение или частное, в строке не + или -, есть * или /
                            str_Expression = str_Expression.Replace(str_Part_2, rezult_D);   // заменяем иследуемую часть строки на  произведение или частное
                        }

                        str_Action = str_Action.Substring(position_Mu_Di + 1, str_Action.Length - position_Mu_Di - 1);
                        position_Add_Sub = str_Action.IndexOfAny(sing_Arif_Sum);
                    }
                    //-----------     конец     --------------------------------------------



                    //-----------       начало                                                                    --------------
                    //-----------     получаем для вычисления строку в которой знаки + и -, вычисляем сумму       --------------
                    //-----------     или разность и вставляем в иследуемую строку. Вычисления в методе string Summa_Difference(string stroka)                                --------------
                    position_Mu_Di = str_Action.IndexOfAny(sing_Arif_Sum);

                    while (position_Mu_Di != -1)
                    {
                        string rezult_S = Summa_Difference(str_Action);
                        str_Action = "(" + str_Action + ")";

                        int indexReplase = str_Expression.IndexOf(str_Action);
                        int flag = 0;
                        if (Convert.ToDouble(rezult_S) < 0)                                     // если результат отрицательный, меняем в выражении 
                        {                                                                       // соответствующий знак согласно правила математики
                            for (int x = indexReplase; x > -1; x--)
                            {
                                char str5 = str_Expression[x];
                                if (str_Expression[x] == '+' && Convert.ToDouble(rezult_S) < 0 && flag == 0)
                                {
                                    str_Expression = str_Expression.Remove(x, 1);
                                    str_Expression = str_Expression.Insert(x, "-");
                                    rezult_S = rezult_S.Substring(1, rezult_S.Length - 1);
                                    flag = -1;
                                }
                                if (str_Expression[x] == '-' && Convert.ToDouble(rezult_S) < 0 && flag == 0)
                                {
                                    str_Expression = str_Expression.Remove(x, 1);
                                    str_Expression = str_Expression.Insert(x, "+");
                                    rezult_S = rezult_S.Substring(1, rezult_S.Length - 1);
                                    flag = -1;
                                }
                            }
                        }
                        str_Expression = str_Expression.Replace(str_Action, rezult_S);
                        position_Mu_Di = -1;
                    }
                    //-----------      конец

                    position_Skobka = str_Expression.IndexOfAny(sing_Arif_Sk);  // проверяем на наличее скобок, если есть повторяем цикл
                }// скобки

                // -----------------Вывод результата--------------------
                string Number1 = str_Expression;
                if (Flag == 1)                                //результат проверки положения и количества скобок. Метод Check(string element_Str)
                {
                    Decision.Text = "Ответ: " + Number1;
                }
                else
                {
                    Decision.Text = "Не верная строка";
                }
                // -----------------Вывод результата--------------------

                //----------------------- метод проверки положения и количества скобок в выражении -------------
                bool Check(string element_Str)
                {
                    Stack<char> stack_Str = new Stack<char>();
                    Dictionary<char, char> dicSkoba = new Dictionary<char, char>
                        {
                          {'(',')'},
                        };
                    foreach (char c in element_Str)
                    {
                        if (c == '(')
                        {
                            stack_Str.Push(dicSkoba[c]);
                        }
                        if (c == ')')
                        {
                            if (stack_Str.Count == 0 || stack_Str.Pop() != c)
                            {
                                return false;
                            }
                        }
                    }
                    if (stack_Str.Count == 0)
                        return true;
                    else
                        return false;
                }//----------------------- метод проверки положения и количества скобок в выражении -------------

                //------------------------ Вычисление сложения и разности в выражении ---------------------------
                string Summa_Difference(string stroka)
                {
                    string rezultat = "";


                    int pos_Sing = stroka.IndexOfAny(sing_Arif_Sum);//позиция первого арифметического знака или + или -
                    if (stroka.Substring(0, 1) != "-")
                    {
                        stroka = "+" + stroka;                       // если первый член выражения положительный, добавляем 
                    }                                                // + в начало выражения
                    double figure_1 = 0;
                    string str_Figure = "";
                    while (pos_Sing != -1)
                    {
                        string sing_First = stroka.Substring(0, 1);                  //получаем первый арифметический знак
                        string str_3 = stroka.Substring(1, stroka.Length - 1);      //промежуточные действия, обрезали первый арифм знак
                        int pos_Second = stroka.Substring(1, stroka.Length - 1).IndexOfAny(sing_Arif_Sum);//получаем позицию второго арифметического знака
                        if (pos_Second != -1)                                          //получаем строку, член выражения для накопления
                        {
                            str_Figure = stroka.Substring(1, stroka.Length - 1).Substring(0, pos_Second); //если в необработанной части есть + или -
                        }
                        else
                        {
                            str_Figure = stroka.Substring(1, stroka.Length - 1);      //если в необработанной части остался только элемент для накопления
                        }
                        if (sing_First == "+")
                        {
                            figure_1 += Convert.ToDouble(str_Figure);
                        }
                        if (sing_First == "-")
                        {
                            figure_1 -= Convert.ToDouble(str_Figure);
                        }
                        stroka = stroka.Substring(pos_Second + 1, stroka.Length - pos_Second - 1); // удаляем учтенную часть от строки выражения 
                        pos_Sing = str_3.IndexOfAny(sing_Arif_Sum);                          //позиция первого арифметического знака или + или -
                        rezultat = Convert.ToString(figure_1);
                    }                                                                        // если в выражении остались + или - повторяем в цикле
                    return rezultat;                                                        // возвращаем результат в основную часть
                }
                //--------------------------Вычисление сложения и разности в выражении---------------------------------------------------------

                //--------------------------Вычисление произведения и частного в выражении-----------------------------------------------------
                string Division(string stroka)
                {


                    string rezultat = "";


                    int pos_Sing = stroka.IndexOfAny(sing_Arif_Div);//позиция первого арифметического знака
                    stroka = "*" + stroka;                                                             // если первый член выражения положительный, добавляем + в начало выражения
                    double figure_1 = 1;
                    string str_Figure = "";
                    while (pos_Sing != -1)
                    {
                        string sing_First = stroka.Substring(0, 1);                                      //получаем первый арифметический знак
                        string str_3 = stroka.Substring(1, stroka.Length - 1);                           //промежуточные действия, обрезали первый арифм знак
                        int pos_First = stroka.Substring(1, stroka.Length - 1).IndexOfAny(sing_Arif_Div);//получаем позицию второго арифметического знака
                        if (pos_First != -1)
                        {
                            str_Figure = stroka.Substring(1, stroka.Length - 1).Substring(0, pos_First); //если в необработанной части есть * или /
                        }
                        else
                        {
                            str_Figure = stroka.Substring(1, stroka.Length - 1);
                        }
                        if (sing_First == "*")
                        {
                            figure_1 *= Convert.ToDouble(str_Figure);
                        }
                        if (sing_First == "/")
                        {
                            figure_1 /= Convert.ToDouble(str_Figure);
                        }
                        stroka = stroka.Substring(pos_First + 1, stroka.Length - pos_First - 1);    // удаляем учтенную часть от строки выражения 
                        pos_Sing = str_3.IndexOfAny(sing_Arif_Div);                                 //позиция первого арифметического знака или * или /
                        rezultat = Convert.ToString(figure_1);
                    }                                                                                // если в выражении остались * или / повторяем в цикле
                    return rezultat;                                                                 // возвращаем результат в основную часть
                    //---------------------------Вычисление произведения и частного в выражении---------------------------------------------------------
                }
            }
        }
    }
}

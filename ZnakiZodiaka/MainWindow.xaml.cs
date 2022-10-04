using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace ZnakiZodiaka
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Background = new ImageBrush(new BitmapImage(new Uri(@"pack://application:,,,/Resources/bg.jpg")));

        }

        private void day_PreviewTextInput(object sender, TextCompositionEventArgs e) // ВВОД ТОЛЬКО ЦИФР
        {
            char c = Convert.ToChar(e.Text);
            if (Char.IsNumber(c))
                e.Handled = false;
            else
                e.Handled = true;
            base.OnPreviewTextInput(e);
        }

        private void calculateZnak_Click(object sender, RoutedEventArgs e)
        {
            

            //БЛОК ПРОВЕРКИ НА КОРРЕКТНОСТЬ ВВОДИМОГО ДНЯ
            if (birthDay.Text == "" || monthsList.Text == "")
            {
                MessageBox.Show($"Вы не ввели значение", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                int day = Convert.ToInt32(birthDay.Text);
                string month = monthsList.Text;
                if (Convert.ToInt32(day) > 31) MessageBox.Show($"Число {day} не является корректным для календарного дня", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                else if ((month == "Апрель" || month == "Июнь" || month == "Сентябрь" || month == "Ноябрь") && day > 30)
                    MessageBox.Show($"В данном месяце всего 30 дней!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                else if (month == "Февраль" && day > 28)
                    MessageBox.Show($"В данном месяце всего 28 дней!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);

                //БЛОК РАССЧЕТА ЗНАКА ЗОДИАКА

                else if ((month == "Март" && day >= 21) || (month == "Апрель" && day <= 20))
                {
                    signs.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/Resources/aries.png"));
                    signText.Text = "ОВЕН";
                    signText.Foreground = Brushes.Yellow;
                }
                else if ((month == "Апрель" && day >= 21) || (month == "Май" && day <= 21))
                {
                    signs.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/Resources/taurus.png"));
                    signText.Text = "ТЕЛЕЦ";
                    signText.Foreground = Brushes.Blue;
                }
                else if ((month == "Май" && day >= 22) || (month == "Июнь" && day <= 21))
                {
                    signs.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/Resources/gemini.png"));
                    signText.Text = "БЛИЗНЕЦЫ";
                    signText.Foreground = Brushes.Brown;
                }
                else if ((month == "Июнь" && day >= 22) || (month == "Июль" && day <= 22))
                {
                    signs.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/Resources/cancer.png"));
                    signText.Text = "РАК";
                    signText.Foreground = Brushes.Purple;
                }
                else if ((month == "Июль" && day >= 23) || (month == "Август" && day <= 23))
                {
                    signs.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/Resources/leo.png"));
                    signText.Text = "ЛЕВ";
                    signText.Foreground = Brushes.Brown;
                }
                else if ((month == "Август" && day >= 24) || (month == "Сентябрь" && day <= 22))
                {
                    signs.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/Resources/virgo.png"));
                    signText.Text = "ДЕВА";
                    signText.Foreground = Brushes.Pink;
                }
                else if ((month == "Сентябрь" && day >= 23) || (month == "Октябрь" && day <= 22))
                {
                    signs.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/Resources/libra.png"));
                    signText.Text = "ВЕСЫ";
                    signText.Foreground = Brushes.LightGreen;
                }
                else if ((month == "Октябрь" && day >= 23) || (month == "Ноябрь" && day <= 22))
                {
                    signs.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/Resources/scorpio.png"));
                    signText.Text = "СКОРПИОН";
                    signText.Foreground = Brushes.OrangeRed;
                }
                else if ((month == "Ноябрь" && day >= 23) || (month == "Декабрь" && day <= 21))
                {
                    signs.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/Resources/sagittarius.png"));
                    signText.Text = "СТРЕЛЕЦ";
                    signText.Foreground = Brushes.Violet;
                }
                else if ((month == "Декабрь" && day >= 22) || (month == "Январь" && day <= 20))
                {
                    signs.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/Resources/capricorn.png"));
                    signText.Text = "КОЗЕРОГ";
                    signText.Foreground = Brushes.Brown;
                }
                else if ((month == "Январь" && day >= 21) || (month == "Февраль" && day <= 19))
                {
                    signs.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/Resources/aquarius.png"));
                    signText.Text = "ВОДОЛЕЙ";
                    signText.Foreground = Brushes.Turquoise;

                }
                else if ((month == "Февраль" && day >= 20) || (month == "Март" && day <= 20))
                {
                    signs.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/Resources/fish.png"));
                    signText.Text = "РЫБЫ";
                    signText.Foreground = Brushes.Blue;
                }
            }
          
        }

        private void year_PreviewTextInput(object sender, TextCompositionEventArgs e) // ВВОД ТОЛЬКО ЦИФР
        {
            char c = Convert.ToChar(e.Text);
            if (Char.IsNumber(c))
                e.Handled = false;
            else
                e.Handled = true;
            base.OnPreviewTextInput(e);
        }

        private void calculateGor_Click(object sender, RoutedEventArgs e)
        {

                if (birthYear.Text == "")
                {
                    MessageBox.Show($"Вы не ввели значение", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    int year = Convert.ToInt32(birthYear.Text);
                    string[] signs = { "Крыса", "Бык", "Тигр", "Кот", "Дракон", "Змея", "Лошадь", "Коза", "Обезьяна", "Петух", "Собака", "Кабан" };
                    int a;
                    int sign = 0;
                    if (year >= 1900)
                    {
                        a = 1899;
                        while (a < year)
                        {
                            for (int i = 0; i < 12 && a < year; i++)
                            {
                                a++;
                                sign = i;
                            }
                        }
                    }
                    if (year < 1900)
                    {
                        a = 1900;
                        while (a > year)
                        {
                            for (int i = 11; i > 0 && a > year; i--)
                            {
                                a--;
                                sign = i;
                            }
                        }
                    }

                    if (sign == 0)
                    {
                        signsVost.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/Resources/rat.png"));
                        textVost.Text = "КРЫСА";
                        textVost.Foreground = Brushes.Red;
               
                    }
                    if (sign == 1)
                    {
                        signsVost.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/Resources/bull.png"));
                        textVost.Text = "БЫК";
                        textVost.Foreground = Brushes.Red;
               
                    }
                    if (sign == 2)
                    {
                        signsVost.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/Resources/tiger.png"));
                        textVost.Text = "ТИГР";
                        textVost.Foreground = Brushes.Red;
                  
                    }
                    if (sign == 3)
                    {
                        signsVost.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/Resources/rabbit.png"));
                        textVost.Text = "КРОЛИК";
                        textVost.Foreground = Brushes.Red;
             
                    }
                    if (sign == 4)
                    {
                        signsVost.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/Resources/dragon.png"));
                        textVost.Text = "ДРАКОН";
                        textVost.Foreground = Brushes.Red;
                 
                    }
                    if (sign == 5)
                    {
                        signsVost.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/Resources/snake.png"));
                        textVost.Text = "ЗМЕЯ";
                        textVost.Foreground = Brushes.Red;
                       
                    }
                    if (sign == 6)
                    {
                        signsVost.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/Resources/horse.png"));
                        textVost.Text = "ЛОШАДЬ";
                        textVost.Foreground = Brushes.Red;
                       
                    }
                    if (sign == 7)
                    {
                        signsVost.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/Resources/goat.png"));
                        textVost.Text = "КОЗА";
                        textVost.Foreground = Brushes.Red;
                      
                    }
                    if (sign == 8)
                    {
                        signsVost.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/Resources/monkey.png"));
                        textVost.Text = "ОБЕЗЬЯНА";
                        textVost.Foreground = Brushes.Red;
                        
                    }
                    if (sign == 9)
                    {
                        signsVost.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/Resources/cock.png"));
                        textVost.Text = "ПЕТУХ";
                        textVost.Foreground = Brushes.Red;
                      
                    }
                    if (sign == 10)
                    {
                        signsVost.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/Resources/dog.png"));
                        textVost.Text = "СОБАКА";
                        textVost.Foreground = Brushes.Red;
                        
                    }
                    if (sign == 11)
                    {
                        signsVost.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/Resources/hog.png"));
                        textVost.Text = "КАБАН";
                        textVost.Foreground = Brushes.Red;
                       
                    }

                }
            
            }
            

        private void choiceZnak_Click(object sender, RoutedEventArgs e)
        {
            pictureZodiag.Visibility = Visibility.Collapsed;
            textZodiag.Visibility = Visibility.Collapsed;
            buttonZodiag.Visibility = Visibility.Collapsed;
            pictureCalendar.Visibility = Visibility.Collapsed;
            textCalendar.Visibility = Visibility.Collapsed;
            buttonCalendar.Visibility = Visibility.Collapsed;
            znakZodiakaLeft.Visibility = Visibility.Visible;
            znakZodiakaRight.Visibility = Visibility.Visible;
        }

        private void choiceCalendar_Click(object sender, RoutedEventArgs e)
        {
            pictureZodiag.Visibility = Visibility.Collapsed;
            textZodiag.Visibility = Visibility.Collapsed;
            buttonZodiag.Visibility = Visibility.Collapsed;
            pictureCalendar.Visibility = Visibility.Collapsed;
            textCalendar.Visibility = Visibility.Collapsed;
            buttonCalendar.Visibility = Visibility.Collapsed;
            vostGoroskopLeft.Visibility = Visibility.Visible;
            vostGoroskopRight.Visibility = Visibility.Visible;
        }

        private void backToMainFromZodiag_Click(object sender, RoutedEventArgs e)
        {
            znakZodiakaLeft.Visibility = Visibility.Collapsed;
            znakZodiakaRight.Visibility = Visibility.Collapsed;
            pictureZodiag.Visibility = Visibility.Visible;
            textZodiag.Visibility = Visibility.Visible;
            buttonZodiag.Visibility = Visibility.Visible;
            pictureCalendar.Visibility = Visibility.Visible;
            textCalendar.Visibility = Visibility.Visible;
            buttonCalendar.Visibility = Visibility.Visible;
        }
        private void backToMainFromGor_Click(object sender, RoutedEventArgs e)
        {
            vostGoroskopLeft.Visibility = Visibility.Collapsed;
            vostGoroskopRight.Visibility = Visibility.Collapsed;
            pictureZodiag.Visibility = Visibility.Visible;
            textZodiag.Visibility = Visibility.Visible;
            buttonZodiag.Visibility = Visibility.Visible;
            pictureCalendar.Visibility = Visibility.Visible;
            textCalendar.Visibility = Visibility.Visible;
            buttonCalendar.Visibility = Visibility.Visible;
        }
        
    }
}

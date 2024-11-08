using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace prac9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Максимальное количество студентов
        /// </summary>
        private const int MaxStudents = 100;
        /// <summary>
        /// Массив для хранения студентов
        /// </summary>
        private Student[] students = new Student[MaxStudents];
        /// <summary>
        /// Индекс студентов
        /// </summary>
        private int currentStudentIndex = 0;
        public MainWindow()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Обработчик события добавления студента
        /// </summary>
        private void btnAddStudent_Click(object sender, RoutedEventArgs e)
        {
            if (currentStudentIndex >= MaxStudents)
            {
                MessageBox.Show("Достигнуто максимальное количество студентов.", "Ошибка");
                return;
            }

            if (!int.TryParse(tbExperienceYears.Text, out int experienceYears))
            {
                MessageBox.Show("Введите корректный стаж.", "Ошибка");
                return;
            }

            Student student = new Student(
                tbLastName.Text,
                cbNeedsDormitory.IsChecked ?? false,
                experienceYears,
                cbHasWorked.IsChecked ?? false,
                tbEducation.Text,
                tbLanguageLearned.Text
            );

            students[currentStudentIndex] = student;
            lbStudents.Items.Add(student.GetInfo());
            currentStudentIndex++;

            UpdateDormitoryCount();
        }

        /// <summary>
        /// Обновление информации о количестве студентов, нуждающихся в общежитии
        /// </summary>
        private void UpdateDormitoryCount()
        {
            int count = 0;
            for (int i = 0; i < currentStudentIndex; i++)
            {
                if (students[i].NeedsDormitory)
                {
                    count++;
                }
            }
            tbDormitoryCount.Text = $"Нуждаются в общежитии: {count}";
        }

        /// <summary>
        /// Обработчик события выхода из программы
        /// </summary>
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Отображение информации о программе
        /// </summary>
        private void btnAboutProgram_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Программа для учета информации о студентах.", "О программе");
        }

        /// <summary>
        /// Отображение информации о разработчике
        /// </summary>
        private void btnAboutDeveloper_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Программу разработал Демьяхин Роман ИСП-31", "О разработчике");
        }
    }
}
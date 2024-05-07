using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;
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

namespace KnittingProjectRestart
{
    /// <summary>
    /// Interaction logic for ProjectCreation.xaml
    /// </summary>
    public partial class ProjectCreation : UserControl, INotifyPropertyChanged
    {
        public ProjectCreation()
        {
            InitializeComponent();
        }

        public string ProjectNameText { get; set; }
        public ProjectStatus ProjectStatusText { get; set; }
        public string ProjectDescriptionText { get; set; }
        public string PatternNameText { get; set; }

        public ObservableCollection<Project> mProjects = new ObservableCollection<Project>();

        public ObservableCollection<Project> MyProjects
        {
            get { return mProjects; }
            set { mProjects = value; OnPropertyChanged(); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            MyProjects.Add(new Project() { ProjectName = ProjectNameText, PatternName = PatternNameText, Status = ProjectStatusText, ProjectDescription = ProjectDescriptionText });
            OnPropertyChanged();

            // VISUAL STUDIO REALLY DIDN'T LIKE THIS BIT
            Stream stream = null;
            try
            {
                stream = File.Open("file.bin", FileMode.Create);
#pragma warning disable SYSLIB0011 // Type or member is obsolete
                BinaryFormatter bf = new BinaryFormatter();
#pragma warning restore SYSLIB0011 // Type or member is obsolete
                bf.Serialize(stream, MyProjects);
                stream.Close();
            }
            finally
            {
                if(stream != null)
                    stream.Close ();
            }
        }
    }
}

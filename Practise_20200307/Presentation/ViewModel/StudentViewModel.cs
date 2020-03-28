using System;
using System.Collections.ObjectModel;
using System.Linq;
using DAL.Model;
using DAL.Services;
using Presentation.Extensions;


namespace Presentation.ViewModel
{
    public class StudentViewModel : ViewModelBase.ViewModelBase
    {
        private ObservableCollection<Student> students;
        private Student selectedStudent;
        private readonly IStudentService studentService;

        public StudentViewModel(IStudentService studentService)
        {            
            if (studentService == null) throw new ArgumentNullException(nameof(studentService));

            this.studentService = studentService;
            Students = new ObservableCollection<Student>();

            GetStudentsCommmand = new DelegateCommand.DelegateCommand(ExecuteGetStudents);
            SaveStudentsCommand = new DelegateCommand.DelegateCommand(ExecuteSaveStudents, CanExecuteSaveStudents);
            RemoveStudentCommmand = new DelegateCommand.DelegateCommand(ExecuteRemoveStudent, CanExecuteRemoveStudent);
        }

        private bool CanExecuteSaveStudents()
        {
            return selectedStudent != null;
        }

        private void ExecuteSaveStudents()
        {
            studentService.SaveStudents(this.Students);
        }

        private void ExecuteGetStudents()
        {
            this.Students = this.studentService.GetStudents().ToObservableCollection();
        }

        private bool CanExecuteGetStudents()
        {
            return !this.Students.Any();
        }

        public ObservableCollection<Student> Students
        {
            get { return students; }
            set
            {
                students = value;
                OnPropertyChanged();
            }
        }

        public Student SelectedStudent
        {
            get { return selectedStudent; }
            set
            {
                selectedStudent = value;
                OnPropertyChanged();
            }
        }

        private void ExecuteRemoveStudent()
        {
            this.studentService.RemoveStudent(this.SelectedStudent);
            this.studentService.SaveStudents(this.Students);
            this.ExecuteGetStudents();
        }

        private bool CanExecuteRemoveStudent()
        {
            return this.Students.Any();
        }

        public DelegateCommand.DelegateCommand RemoveStudentCommmand { get; }

        public DelegateCommand.DelegateCommand GetStudentsCommmand { get; }

        public DelegateCommand.DelegateCommand SaveStudentsCommand { get; }

    }
}
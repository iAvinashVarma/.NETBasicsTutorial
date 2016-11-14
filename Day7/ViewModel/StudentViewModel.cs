using Day7.Model;
using System.Collections.ObjectModel;
using System.Xml.Linq;

namespace Day7.ViewModel
{
	class StudentViewModel
	{
		private ObservableCollection<StudentModel> studentList;

		public ObservableCollection<StudentModel> StudentList
		{
			get { return studentList; }
			set { studentList = value; }
		}

		internal void LoadStudentListView()
		{
			XDocument studentsDocument = XDocument.Load(@"Resources\Data\Students.xml");
			var studentElements = studentsDocument.Descendants("Student");
			StudentList = new ObservableCollection<StudentModel>();
			foreach (var student in studentElements)
			{
				StudentList.Add(new StudentModel
				{
					Id = int.Parse(student.Attribute("ID").Value),
					Name = student.Attribute("Name").Value,
					Address = student.Attribute("Address").Value
				});
			}
		}
	}
}

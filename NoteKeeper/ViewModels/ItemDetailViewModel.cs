using System;
using System.Collections.Generic;
using NoteKeeper.Models;

namespace NoteKeeper.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        private string noteHeading;

        public Note Note { get; set; }

        public IList<string> CourseList { get; set; }

        public string NoteHeading
        {
            get => Note.Heading;
            set
            {
                Note.Heading = value;
                OnPropertyChanged();
            }
        }
        public ItemDetailViewModel(Note note = null)
        {
            InitializeCourseList();
            Note = note ?? new Note();
            Title = "Edit Note";
        }

        async void InitializeCourseList()
        {
            CourseList = await PluralsightDataStore.GetCoursesAsync();
        }
    }
}

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using UAS.Models;
using UAS.Services;

namespace UAS.Pages
{
    public partial class AddStudent
    {
        public Student Student { get; set; } = new Student();

        [Inject]
        public IStudentService StudentService { get; set; }

        [Inject]
        public NavigationManager NavigationManager {get; set;} 

        public List<Student> Students { get; set; } = new List<Student>();

        protected async override Task OnInitializedAsync()
        {
             Students = (await StudentService.GetAll()).ToList();
        }
        
        protected async Task HandleValidSubmit()
        {
            var result = await StudentService.Add(Student);
            NavigationManager.NavigateTo("/studentpage");
        }
    }
}
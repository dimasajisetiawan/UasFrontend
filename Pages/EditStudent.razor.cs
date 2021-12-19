using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using UAS.Models;
using UAS.Services;

namespace UAS.Pages
{
    public partial class EditStudent 
    {
       public Student Student { get; set; } = new Student();

        [Inject]
        public IStudentService StudentService { get; set; }

        [Inject]
        public NavigationManager NavigationManager {get; set;} 

        public List<Student> Students { get; set; } = new List<Student>();

        [Parameter]
        public string id { get; set; }

        protected async override Task OnInitializedAsync()
        {
             Student = await StudentService.GetById(int.Parse(id));
        }
        
        protected async Task HandleValidSubmit()
        {
            var result = await StudentService.Update(Student);
            NavigationManager.NavigateTo("/studentpage");
        }  

    }
}
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using UAS.Models;
using UAS.Services;

namespace UAS.Pages
{
    public partial class DetailStudent 
    {  
        [Parameter]

        public string id { get; set; }

        [Inject]
        public IStudentService StudentService {get; set;}

        public Student Student {get; set;} = new Student();

        protected override async Task OnInitializedAsync()
        {
            id = id ?? "1";
            Student = await StudentService.GetById(int.Parse(id));
        }
    }
}
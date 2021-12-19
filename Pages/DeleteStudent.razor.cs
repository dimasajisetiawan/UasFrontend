using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using UAS.Models;
using UAS.Services;

namespace UAS.Pages
{
    public partial class DeleteStudent
    {
        public Student Student { get; set; } = new Student();

        [Inject]
        public IStudentService StudentService {get; set;}

        [Inject]
        public NavigationManager NavigationManager {get; set;}

        [Parameter]
        public string Id {get; set;}

        protected async override Task OnInitializedAsync()
        {
            await StudentService.Delete(int.Parse(Id));
            NavigationManager.NavigateTo("/studentpage");
        }

    }
}
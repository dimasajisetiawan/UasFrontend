using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using UAS.Models;
using UAS.Services;

namespace UAS.Pages {

    public partial class EnrollmentPage 
    {
        public List<Enrollment> Enrollment  { get; set; } = new List<Enrollment>();

        [Inject]
        public IEnrollmentService EnrollmentService { get; set; }

        [Parameter]
        public string Id { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Enrollment = (await EnrollmentService.GetById(int.Parse(Id))).ToList();

        }
    }

}
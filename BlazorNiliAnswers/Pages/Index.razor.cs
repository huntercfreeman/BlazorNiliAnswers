using BlazorNiliAnswers.Models;
using BlazorNiliAnswers.Repositories;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorNiliAnswers.Pages
{
    public partial class Index : ComponentBase
    {
        [Inject]
        public IPersonRepository PersonRepository { get; set; }
        public List<Person> People { get; set; }

        protected override void OnInitialized()
        {
            base.OnInitialized();
            People = PersonRepository.GetPeople();
        }
    }
}

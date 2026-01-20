using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.UseCases.Projects.GetProjects;
using MediatR;

namespace AvaloniaUI.ViewModels
{
    public sealed class MainWindowViewModel
    {
        private readonly IMediator _mediator;
        public string Title => "Initialized UI with DI Container";    
        public MainWindowViewModel(IMediator mediator)
        {
            _mediator = mediator;
            _ = LoadAsync();
        }
        private async Task LoadAsync()
        {
            var projects = await _mediator.Send(new GetProjectsQuery());
            Console.WriteLine($"Loaded Projects: {projects}");
        }
    }
}
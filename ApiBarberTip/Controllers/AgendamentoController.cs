
// utilização de outros namespaces

using BarberTip.Services;//add() Remove() Update() Find()
using BarberTip.ViewModels;//Design pattern - MVVM(Cria uma camada de dados para a view)
using Microsoft.AspNetCore.Mvc;// trabalha com AspNet core MVC

// Definição do namespace
namespace BarberTip.Controllers;

[Route("api/agendamento")] //caminho sub url
[ApiController]// define como API por que pode ter outras aplicações
public class AgendamentoController:ControllerBase{

    private readonly AgendamentoService _agendamentoService;

    public AgendamentoController(AgendamentoService agendamentoService)
    {
        _agendamentoService = agendamentoService;
    }
    [HttpPost]
    public IActionResult AdicionarAgendamento(AdicionarAgendamentoViewModel dados){

        var agendamento = _agendamentoService.AdicionarAgendamento(dados);
        return Ok (agendamento); //Status Http 200.


    }
}


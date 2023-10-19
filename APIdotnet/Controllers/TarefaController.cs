using Microsoft.AspNetCore.Mvc;
using TrilhaApiDesafio.Context;
using TrilhaApiDesafio.Models;

namespace TrilhaApiDesafio.Controllers{
    [ApiController]
    [Route("[controller]")]
    public class TarefaController : ControllerBase{
        private readonly OrganizadorContext _context;

        public TarefaController(OrganizadorContext context){
            _context = context;
        }

        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id){
            var task = _context.Tarefas.Find(id);

            if (task == null)
                return NotFound();

            return Ok(task);
        }

        [HttpGet("ObterTodos")]
        public IActionResult ObterTodos(){
            var task = _context.Tarefas.ToList();
            return Ok(task);
        }

        [HttpGet("ObterPorTitulo")]
        public IActionResult ObterPorTitulo(string titulo){
            var task = _context.Tarefas.Where(x => x.Titulo.ToUpper().Contains(titulo.ToUpper())).ToList();
            return Ok(task);
        }

        [HttpGet("ObterPorData")]
        public IActionResult ObterPorData(DateTime data){
            var task = _context.Tarefas.Where(x => x.Data.Date == data.Date);
            return Ok(task);
        }

        [HttpGet("ObterPorStatus")]
        public IActionResult ObterPorStatus(EnumStatusTarefa status){
            var task = _context.Tarefas.Where(x => x.Status == status);
            return Ok(task);
        }

        [HttpPost]
        public IActionResult Criar(Tarefa task){
            if (task.Data == DateTime.MinValue) return BadRequest(new { Erro = "A data da task não pode ser vazia" });

            _context.Tarefas.Add(task);
            _context.SaveChanges();
            return CreatedAtAction(nameof(ObterPorId), new { id = task.Id }, task);
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Tarefa task){
             var taskBank = _context.Tarefas.Find(id);

            if (taskBank == null)
                return NotFound();

            if (task.Data == DateTime.MinValue)
                return BadRequest(new { Erro = "A data da task não pode ser vazia" });

            taskBank.Titulo = task.Titulo;
            taskBank.Descricao = task.Descricao;
            taskBank.Data = task.Data;
            taskBank.Status = task.Status;

            _context.Tarefas.Update(taskBank);
            _context.SaveChanges();

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id){
            var taskBank = _context.Tarefas.Find(id);

            if (taskBank == null)
                return NotFound();

            _context.Tarefas.Remove(taskBank);
            _context.SaveChanges();

            return NoContent();
        }
    }
}

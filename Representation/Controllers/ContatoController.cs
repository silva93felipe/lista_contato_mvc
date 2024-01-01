using Microsoft.AspNetCore.Mvc;

namespace contato_mvc.Representation.Controllers
{
    public class ContatoController : Controller
    {
        /* private readonly AgendaContext _context;
        public ContatoController(AgendaContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var contatos = _context.Contatos.Include(c => c.Telefones).ToList();
            return View(contatos);
        }

        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(Contato contato)
        {
            if(ModelState.IsValid)
            {
                _context.Contatos.Add(contato);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(contato);
        }

        public IActionResult Editar(int id)
        {
            var contato = _context.Contatos.Include(c => c.Telefones).FirstOrDefault( c => c.Id == id);

            if(contato == null)
                return RedirectToAction(nameof(Index));
            return View(contato);
        }

        [HttpPost]
        public IActionResult Editar(Contato contato)
        {
            var contatoDb = _context.Contatos.Include(c => c.Telefones).FirstOrDefault( c => c.Id == contato.Id);
            
            contatoDb.Ativo = contato.Ativo;
            contatoDb.Nome = contato.Nome;
            if(contato.Ativo){
                if(contatoDb.Telefones != null){
                    foreach (var tel in contatoDb.Telefones)
                    {
                        tel.Ativo = true;
                        tel.UpdateAt = DateTime.UtcNow;
                    }
                }
            }else{
                if(contatoDb.Telefones != null){
                    foreach (var tel in contatoDb.Telefones)
                    {
                        tel.Ativo = false;
                        tel.UpdateAt = DateTime.UtcNow;
                    }
                }
            } 

            _context.Contatos.Update(contatoDb);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Detalhes(int id)
        {
            var contato = _context.Contatos.Include(c => c.Telefones).FirstOrDefault( c => c.Id == id);
            if(contato == null)
                return RedirectToAction(nameof(Index));
            
            return View(contato);

        }

        public IActionResult Deletar(int id)
        {
            var contato = _context.Contatos.Include(c => c.Telefones).FirstOrDefault( c => c.Id == id);
            if(contato == null)
                return RedirectToAction(nameof(Index));
            
            return View(contato);
        }

        [HttpPost]
        public IActionResult Deletar(Contato contato, bool acao)
        {
            var contatoDb = _context.Contatos.Include(c => c.Telefones).FirstOrDefault( c => c.Id == contato.Id);
            if(contatoDb == null)
                return RedirectToAction(nameof(Index));

          contatoDb.Ativo = acao;
            contatoDb.UpdateAt = DateTime.UtcNow;

            if(acao && contatoDb.Telefones != null){
                foreach (var tel in contatoDb.Telefones)
                {
                    tel.Ativo = true;
                    tel.UpdateAt = DateTime.UtcNow;
                }
            }else if (!acao && contatoDb.Telefones != null){
                foreach (var tel in contatoDb.Telefones)
                {
                    tel.Ativo = false;
                    tel.UpdateAt = DateTime.UtcNow;
                }
            } 
            _context.SaveChanges();
            
            return RedirectToAction(nameof(Index));
        }

        public IActionResult TelefoneDeletar(int id)
        {
            var telefone = _context.Telefone.Find(id);
            if(telefone == null)
                return RedirectToAction(nameof(Index));

            _context.Remove(telefone);
            _context.SaveChanges();
            
            return RedirectToAction(nameof(Index));
        }*/
    }
}
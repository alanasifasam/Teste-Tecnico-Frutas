using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Linq;
using Teste_Tecnico_Frutas.Data;
using Teste_Tecnico_Frutas.Models;
using X.PagedList;

namespace Teste_Tecnico_Frutas.Controllers
{
    public class FrutaController : Controller
    {
        private readonly Context _context;
        
        public FrutaController(Context context)
        {
            _context = context;
        }

        public IActionResult Index(int? pagina)
        {
            const int itensPorPagina = 10;
            int numeroPagina = (pagina ?? 1);
            var lista = _context.Frutas.OrderBy(d => d.Descricao).ToPagedList(numeroPagina,itensPorPagina);

            return View(lista);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(int Id,Fruta fruta)
        {
            try
            {
                if (Id < 0 || fruta.A < 0 || fruta.B < 0 || fruta.Descricao == null)
                {
                    TempData["Confirmacao"] = "Campo Obrigatório.";
                    return RedirectToAction(nameof(Create));
                }
                else
                {
                    _context.Frutas.Add(fruta);
                    _context.SaveChanges();
                    TempData["Confirmacao"] = "Cadastrado com Sucesso.";
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return RedirectToAction(nameof(Create), fruta);

        }

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var fruta =_context.Frutas.FirstOrDefault(d => d.Id == Id);
            return View(fruta);
        }


        [HttpPost]
        public IActionResult Edit(int Id, Fruta fruta)
        {
            var fruta_db = _context.Frutas.Find(Id);
            try
            {
                if (Id < 0 || fruta.A < 0 || fruta.B < 0 || fruta.Descricao == null)
                {
                    TempData["Confirmacao"] = "Campo Obrigatório.";
                    return RedirectToAction(nameof(Edit),fruta);
                }
                else
                {

                    fruta_db.Id = fruta.Id;
                    fruta_db.Descricao = fruta.Descricao;
                    fruta_db.A = fruta.A;
                    fruta_db.B = fruta.B;
                    fruta_db.Resultado = fruta.Resultado;
                    _context.Frutas.Update(fruta_db);
                    _context.SaveChanges();
                    TempData["Confirmacao"] = "Alterado com Sucesso.";
                }
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return View(fruta_db);

        }


        [HttpGet]
        public IActionResult Delete(int Id)
        {
            var fruta = _context.Frutas.FirstOrDefault(d => d.Id == Id);
            return View(fruta);
        }


        [HttpPost]
        public IActionResult Delete(int Id,Fruta fruta)
        {
            try
            {
                var fruta_db = _context.Frutas.FirstOrDefault(d => d.Id == Id);
                _context.Frutas.Remove(fruta_db);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            TempData["Confirmacao"] = "Deletado com Sucesso.";
            return View(fruta);
        }


        [HttpGet]
        public IActionResult Calcular(Fruta fruta)
        {
            var fruta_db = _context.Frutas.Find(fruta.Id);
            return View(fruta_db);
        }

        public JsonResult Multiplicar(int Id = 0 ,string DESCRICAO = "" , int A = 0,int B = 0, double RESULTADO = 0)
        {
            
            RESULTADO = (A * B);

            Fruta fruta = new Fruta();
            fruta.Id = Id;
            fruta.Descricao = DESCRICAO;
            fruta.A = A;
            fruta.B = B;    
            fruta.Resultado = RESULTADO;
            
            _context.Update(fruta);
            _context.SaveChanges();
            
            return Json(fruta);
        }

        public JsonResult Dividir(int Id = 0,string DESCRICAO = "", int A = 0, int B = 0, double RESULTADO = 0)
        {
            RESULTADO = Convert.ToDouble(A)/B;
            if(RESULTADO.Equals(double.NaN)) { RESULTADO = 0; }

            Fruta fruta = new Fruta();
            fruta.Id = Id;
            fruta.Descricao = DESCRICAO;
            fruta.A = A;
            fruta.B = B;
            fruta.Resultado = RESULTADO;
            
            _context.Update(fruta);
            _context.SaveChanges();

            return Json(fruta);
      
        }

    }


    
}

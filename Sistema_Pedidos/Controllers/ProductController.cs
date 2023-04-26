using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Sistema_Pedidos.Models;

namespace Sistema_Pedidos.Controllers
{

    public class ProductController : Controller
    {
        public static List<ProductModel> db = new List<ProductModel>();
        public IActionResult Cadastrar(ProductModel produto)
        {
            ProductModel prod = db.Find(p => p.id == produto.id );
            if(prod != null){
               var index = db.FindIndex(a => a.id == produto.id);
                db[index] = produto;
                return RedirectToAction("Listar");
            }else{
                Random rand = new();
                produto.id = rand.Next(1000, 9999);
                db.Add(produto);
                return RedirectToAction("Listar");
            }
        }

        public IActionResult Listar()
        {
          return View(db);
        }

        public IActionResult SalvarTxt(ProductModel produto)
        {
            string path = @"ListaProdutos.txt";
           
            
    
            using (StreamWriter sw = System.IO.File.CreateText(path))
            {
                 
              foreach (var item in db)
              {
                 sw.WriteLine($"id:{item.id}, Produto:{item.product}, Quantidade:{item.quantity}, Valor:R${item.totalValue};");
              }
               
            }
          
            return RedirectToAction("Listar");
             
        }

        public IActionResult Editar(long id)
        {
            ProductModel produto = db.Find(p => p.id == id );
            if(produto != null){
                return View(produto);
            }
            else{
                return RedirectToAction("Listar");
            }

            
        }

        public IActionResult Excluir(long id)
        {
            ProductModel produto = db.Find(p => p.id == id );
            if(produto != null){
               db.Remove(produto);
               return RedirectToAction("Listar");
            }
            else{
                return RedirectToAction("Listar");
            }
        }
    }
}
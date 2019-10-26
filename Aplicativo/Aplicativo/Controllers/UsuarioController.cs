using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aplicativo.Entidades;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Aplicativo.Controllers
{
    [Route("usuario")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly Servicos.IUsuarioServico _usuarioServico;

        public UsuarioController(Servicos.IUsuarioServico usuarioServico)
        {
            _usuarioServico = usuarioServico;
        }

        [HttpPost]
        public async Task<IActionResult> PostUsuarioAsync([FromBody]Requisicao requisicao)
        {
            if (await _usuarioServico.PostUsuarioAsync(requisicao))
                return Ok(true);

            return Ok(false);
        }

       // [EnableCors("AnotherPolicy")]
        [HttpGet]
        public async Task<IActionResult> GetVerificaLoginAsync(string login)
        {
            if (await _usuarioServico.GetVerificaLoginAsync(login))
                return Ok(true);

            return Ok("Login já existe");
        }

        //public static List<Usuario> usuarios = new List<Usuario>();
        //UsuarioRepository _usuarioRepository = new UsuarioRepository();


        //[HttpGet]
        ////[Route("GetAll")]
        //public IEnumerable GetAll()
        //{
        //    ArrayList newList = new ArrayList();
        //    newList = _usuarioRepository.GetAllUser();
        //    newList.ToArray().AsEnumerable();

        //    return newList;
        //}


        //[HttpGet("{cpf}")]
        //[Route("buscar")]
        //public Usuario GetUserByCpf(string cpf)
        //{
        //    if (string.IsNullOrEmpty(cpf))
        //    {
        //        Console.WriteLine("Cpf inválido ! ");
        //        return null;
        //    }
        //    var u = _usuarioRepository.FindUserByCpf(cpf);
        //    if (u == null)
        //    {
        //        Console.WriteLine("Usuario não encontrado !");
        //        return null;
        //    }
        //    return u;
        //}


        //[HttpPost]
        //[Route("logue")]
        //public IActionResult CreateLogue([FromBody]Usuario usuario)
        //{

        //    if (usuario == null)
        //        return BadRequest();

        //    var retorno = _usuarioRepository.CreateLoge(usuario);

        //    if (retorno < 0)
        //        return BadRequest();

        //    return Ok(retorno);
        //}

        //[HttpPost]
        //[Route("user")]
        //public IActionResult CreateUser([FromBody]Usuario usuario)
        //{

        //    if (usuario == null)
        //        return BadRequest();

        //    Boolean t = _usuarioRepository.FindRegisterByCPF(usuario.Cpf);

        //    if (t == false)
        //    {
        //        _usuarioRepository.CreateUser(usuario);

        //        return Ok(usuario.Cpf);
        //    }
        //    return BadRequest();
        //}

        //[HttpPost]
        //[Route("address")]
        //public IActionResult CreateUserAddress([FromBody]Endereco endereco)
        //{

        //    if (endereco == null)
        //        return BadRequest();

        //    else
        //        _usuarioRepository.CreateUserAddress(endereco);

        //    return Ok();

        //}


        //[HttpPut("{cpf}")]
        ////[Route("update")]
        //public IActionResult UpdateUser(string cpf, [FromBody]Usuario usuario)
        //{
        //    var _CPF = cpf.Replace("-", "").Replace(".", "").Replace("/", "");

        //    if (usuario == null)
        //        return BadRequest();

        //    bool u = _usuarioRepository.FindRegisterByCPF(_CPF);

        //    if (u == false)
        //        return NotFound();  // código 404


        //    _usuarioRepository.UpdateUser(_CPF, usuario);
        //    return new NoContentResult();  // código 204 servidor processou o request - void
        //}


        //[HttpDelete("{cpf}")]
        //public IActionResult DeleteUser(string cpf)
        //{
        //    if (cpf == null)
        //        return NotFound();

        //    var u = _usuarioRepository.FindUserByCpf(cpf);
        //    if (u == null)
        //    {
        //        return NotFound();
        //    }

        //    _usuarioRepository.RemoveUser(cpf);
        //    return new NoContentResult();
        //}

        //[HttpPost("{cpf}")]
        //[Route("qualificacoes")]
        //public IActionResult RegisterQualifiucacoes(string cpf, [FromBody]ArrayList qualificacoes)
        //{

        //    if (cpf == null)
        //        return BadRequest();

        //    else
        //        _usuarioRepository.CadastrarQualificacao(cpf, qualificacoes);

        //    return Ok();

        //}



    }
}

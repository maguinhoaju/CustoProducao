using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CustoProducao.Core.Entities;
using CustoProducao.Infrastructure.Data;
using CustoProducao.WebMVC.ViewModels;
using AutoMapper;
using CustoProducao.Core.Manager.Contracts;
using CustoProducao.Core.Translation;
using Microsoft.AspNetCore.Authorization;

namespace CustoProducao.WebMVC.Controllers
{
//    [Authorize]
    public class EmpresaController : Controller
    {
        private readonly IEmpresaManager _empresaManager;
        private readonly IMapper _mapper;
        private readonly IEntityTranslator _translator;

        public EmpresaController(IEmpresaManager empresaManager, IMapper mapper, IEntityTranslator translator)
        {
            _empresaManager = empresaManager;
            _mapper = mapper;
            _translator = translator;
        }

        // GET: Empresa
        public async Task<IActionResult> Index()
        {
            var empresas = await _empresaManager.ListAllAsync();
            return View(_translator.Translate<List<EmpresaViewModel>>(empresas.ToList()));
        }

        // GET: Empresa/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var empresa = await _empresaManager.GetByIdAsync((int)id);
            if (empresa == null)
            {
                return NotFound();
            }

            return View(empresa);
        }

        // GET: Empresa/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Empresa/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdEmpresa,NrCnpj,NmEmpresa")] EmpresaViewModel empresa)
        {
            if (ModelState.IsValid)
            {
                var result = _mapper.Map <Empresa> (empresa);
                await _empresaManager.AddAsync(result);
                return RedirectToAction(nameof(Index));
            }
            return View(empresa);
        }

        // GET: Empresa/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var empresa = await _empresaManager.GetByIdAsync((int)id);
            if (empresa == null)
            {
                return NotFound();
            }
            return View(empresa);
        }

        // POST: Empresa/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdEmpresa,NrCnpj,NmEmpresa")] EmpresaViewModel empresa)
        {
            if (id != empresa.IdEmpresa)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var result = _mapper.Map<Empresa>(empresa);

                    await _empresaManager.UpdateAsync(result);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmpresaExists(empresa.IdEmpresa))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(empresa);
        }

        // GET: Empresa/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var empresa = await _empresaManager.GetByIdAsync((int)id);
            if (empresa == null)
            {
                return NotFound();
            }

            return View(empresa);
        }

        // POST: Empresa/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var empresa = await _empresaManager.GetByIdAsync((int)id);
            await _empresaManager.DeleteAsync(empresa);
            return RedirectToAction(nameof(Index));
        }

        private bool EmpresaExists(int id)
        {
            return _empresaManager.GetByIdAsync(id) != null;
        }
    }
}

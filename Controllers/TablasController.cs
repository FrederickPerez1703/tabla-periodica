using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Tarea.Controllers
{
    public class TablasController : Controller
    {
        public IActionResult Index()
        {
       
            String[] grupo1 = {"H" ,"LI", "NA", "K", "RB", "CS", "fr" };
            ViewBag.grupo1 = grupo1;

            String[] grupo2 = { "BE", "MG", "CA", "SR", "BA", "RA" };
            ViewBag.grupo2 = grupo2;

            String[] grupo3 = { "Sc", "Y", "Lu", "Lr" };
            ViewBag.grupo3 = grupo3;

            String[] grupoA = { "Ti", "Zr", "HF", "RF" };
            ViewBag.grupoA = grupoA;

            String[] grupoB= { "V", "Nb", "Ta", "Db" };
            ViewBag.grupoB = grupoB;

            String[] grupoC = { "Cr", "Mo", "W", "Sg" };
            ViewBag.grupoC = grupoC;

            String[] grupod = { "Mn", "Tc", "Re", "Bh" };
            ViewBag.grupod = grupod;

            String[] grupoE = { "Fe", "Ru", "Os", "Hs"};
            ViewBag.grupoE = grupoE;

            String[] grupoF = { "Co", "Rh", "Ir", "Mt" };
            ViewBag.grupoF = grupoF;

            String[] vs = { "Ni", "Pd", "Pt", "Ds" };
            ViewBag.vs = vs;
            String[] vs1 = { "Cu", "Ag", "Au", "Rg" };
            ViewBag.vs1 = vs1;
            String[] vs2 = { "Zn", "Cd", "Hg", "Cn" };
            ViewBag.vs2 = vs2;
            String[] vs3 = { "B", "Al", "Ga", "In" , "Ti", "Nh" };
            ViewBag.vs3 = vs3;
            String[] vs4 = { "C", "Si" , "Ge", "Sn", "Pb", "Fl" };
            ViewBag.vs4 = vs4;
            String[] vs5 = { "N", "P", "As", "Sb", "Bi", "Mc" };
            ViewBag.vs5 = vs5;
            String[] vs6 = { "O", "S", "Se", "Te", "Po", "Lv" };
            ViewBag.vs6 = vs6;
            String[] vs7 = { "F", "Cl", "Br", "I", "At", "Ts" };
            ViewBag.vs7 = vs7;
            String[] vs8 = { "He", "Ne", "Ar", "Kr", "Xe", "Rn", "Or" };
            ViewBag.vs8 = vs8;

            String[] Estra1 = {"La", "Ce", "Pr", "Nd", "Pm", "Sm", "Eu", "Gd", "Td", "Dy", "Ho", "Er", "Tm", "Yb"};
            ViewBag.Estra1 = Estra1;

            String[] Estra2 = {"Ac", "Th", "Pa", "U", "Np", "Pu", "Am", "Cm", "Bk", "Cf", "Es", "Fm", "Md", "No"};
            ViewBag.Estra2 = Estra2;
            return View();
        }
    } 
}
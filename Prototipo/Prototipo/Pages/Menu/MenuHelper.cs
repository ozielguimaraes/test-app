﻿using Prototipo.Pages.About;
using Prototipo.Pages.Empreendimento;
using Prototipo.Pages.Proposta;
using Prototipo.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Prototipo.Pages.Menu
{
    public class MenuHelper
    {
        public static Page GetPage(MenuItemVm item)
        {
            switch (item.Type)
            {
                case MenuType.Carteira: return new MainPage();
                case MenuType.Proposta: return new ListaPropostaPage();
                case MenuType.Empreendimento: return new ListaEmpreendimentoPage();
                case MenuType.GravarProposta: return new GravarPropostaPage();
                case MenuType.About: return new AboutPage();
                default: return new MainPage();
            }
        }

        public static async Task<IEnumerable<MenuItemVm>> Build()
        {
            var items = new List<MenuItemVm>
            {
                new MenuItemVm("Minha carteira", "carteira", MenuType.Carteira),
                new MenuItemVm("Nova proposta", "proposta", MenuType.GravarProposta),
                new MenuItemVm("Minhas propostas", "proposta", MenuType.Proposta),
                new MenuItemVm("Meus empreendimentos", "empreendimento", MenuType.Empreendimento),
                new MenuItemVm("Sobre", "about", MenuType.About),
            };

            await Task.Delay(1);
            return items;
        }
    }
}
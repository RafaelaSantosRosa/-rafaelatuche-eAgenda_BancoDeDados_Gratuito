using eAgenda.Controladores.CompromissoModule;
using eAgenda.Controladores.ContatoModule;
using eAgenda.Controladores.Shared;
using eAgenda.Dominio.CompromissoModule;
using eAgenda.Dominio.ContatoModule;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace eAgenda.Tests.CompromissoModule
{
    [TestClass]
    public class ControladorCompromissoTest
    {
        ControladorCompromisso controladorCompromisso = null;
        ControladorContato controladorContato = null;

        public ControladorCompromissoTest()
        {
            controladorCompromisso = new ControladorCompromisso();
            controladorContato = new ControladorContato();
            Db.Update("DELETE FROM [TBCOMPROMISSO]");
            Db.Update("DELETE FROM [TBCONTATO]");
        }

        [TestMethod]
        public void DeveInserirCompromisso_SemContato()
        {
            //arrange
            Compromisso novoCompromisso = new Compromisso("trabalho", "padaria", "", DateTime.Today, 
                new TimeSpan(3, 17, 25, 30), new TimeSpan(4, 17, 25, 30), null);

            //action
            controladorCompromisso.InserirNovo(novoCompromisso);

            //assert
            var compromissoEncontrado = controladorCompromisso.SelecionarPorId(novoCompromisso.Id);
            compromissoEncontrado.Should().Be(novoCompromisso);
        }

        [TestMethod]
        public void DeveInserirCompromisso_ComContato()
        {
            //arrange
            Contato contato = new Contato("Rafaela", "rafa@gmail.com", "999121315", "ndd", "estagiária");
            controladorContato.InserirNovo(contato);

            Compromisso novoCompromisso = new Compromisso("trabalho", "padaria", "", DateTime.Today,
                new TimeSpan(3, 17, 25, 30), new TimeSpan(4, 17, 25, 30), controladorContato.SelecionarPorId(contato.Id));

            //action
            controladorCompromisso.InserirNovo(novoCompromisso);

            //assert
            var compromissoEncontrado = controladorCompromisso.SelecionarPorId(novoCompromisso.Id);
            compromissoEncontrado.Should().Be(novoCompromisso);
        }

        [TestMethod]
        public void Nao_DeveInserir_Compromisso_NaMesmaData_NoMesmoHorario()
        {
            //arrange
            Compromisso compromisso = new Compromisso("faculdade", "ifsc", "", DateTime.Today,
                new TimeSpan(13, 00, 00), new TimeSpan(14, 00, 00), null);

            controladorCompromisso.InserirNovo(compromisso);

            Compromisso novoCompromisso = new Compromisso("trabalho", "padaria", "", DateTime.Today,
                new TimeSpan(13, 00, 00), new TimeSpan(14, 00, 00), null);

            //action
            string resultado = controladorCompromisso.InserirNovo(novoCompromisso);

            //assert
            resultado.Should().Be("Nesta data e horário já existe um compromisso agendado");
            List<Compromisso> compromissos = controladorCompromisso.SelecionarTodos();

            compromissos.Should().HaveCount(1);
        }

        [TestMethod]
        public void DeveInserir_Compromisso_NoMesmoHorario_Termino()
        {
            //arrange
            Compromisso compromisso = new Compromisso("faculdade", "ifsc", "", DateTime.Today,
                new TimeSpan(13, 00, 00), new TimeSpan(14, 00, 00), null);

            controladorCompromisso.InserirNovo(compromisso);

            Compromisso novoCompromisso = new Compromisso("trabalho", "padaria", "", DateTime.Today,
                new TimeSpan(14, 00, 00), new TimeSpan(15, 00, 00), null);

            //action
            controladorCompromisso.InserirNovo(novoCompromisso);

            //assert
            var compromissoEncontrado = controladorCompromisso.SelecionarPorId(novoCompromisso.Id);
            compromissoEncontrado.Should().Be(novoCompromisso);
        }

        [TestMethod]
        public void DeveAtualizar_Compromisso()
        {
            //arrange
            Compromisso compromisso = new Compromisso("faculdade", "ifsc", "", DateTime.Today,
                new TimeSpan(13, 00, 00), new TimeSpan(14, 00, 00), null);

            controladorCompromisso.InserirNovo(compromisso);

            Compromisso novoCompromisso = new Compromisso("trabalho", "padaria", "", DateTime.Today,
                new TimeSpan(3, 17, 25, 30), new TimeSpan(4, 17, 25, 30), null);

            //action
            controladorCompromisso.Editar(compromisso.Id, novoCompromisso);

            //assert
            Compromisso compromissoAtualizado = controladorCompromisso.SelecionarPorId(compromisso.Id);
            compromissoAtualizado.Should().Be(novoCompromisso);
        }

        [TestMethod]
        public void NaoDeveAtualizar_Compromisso_HorarioOcupado()
        {
            //arrange
            Compromisso compromisso1 = new Compromisso("faculdade", "ifsc", "", DateTime.Today,
                new TimeSpan(13, 00, 00), new TimeSpan(14, 00, 00), null);

            controladorCompromisso.InserirNovo(compromisso1);

            Compromisso compromisso2 = new Compromisso("faculdade", "ifsc", "", DateTime.Today,
                new TimeSpan(15, 00, 00), new TimeSpan(16, 00, 00), null);

            controladorCompromisso.InserirNovo(compromisso2);

            Compromisso novoCompromisso = new Compromisso("trabalho", "padaria", "", DateTime.Today,
                new TimeSpan(15, 00, 00), new TimeSpan(16, 00, 00), null);

            //action
            string resultado = controladorCompromisso.Editar(compromisso1.Id, novoCompromisso);

            //assert
            resultado.Should().Be("Nesta data e horário já existe um compromisso agendado");
            List<Compromisso> compromissos = controladorCompromisso.SelecionarTodos();

            compromissos.Should().HaveCount(2);
        }

        [TestMethod]
        public void DeveAtualizar_Compromisso_InserindoContato()
        {
            //arrange
            Compromisso compromisso = new Compromisso("faculdade", "ifsc", "", DateTime.Today,
                new TimeSpan(13, 00, 00), new TimeSpan(14, 00, 00), null);

            controladorCompromisso.InserirNovo(compromisso);

            Contato contato = new Contato("Rafaela", "rafa@gmail.com", "999121315", "ndd", "estagiária");
            controladorContato.InserirNovo(contato);

            Compromisso novoCompromisso = new Compromisso("trabalho", "padaria", "", DateTime.Today,
                new TimeSpan(3, 17, 25, 30), new TimeSpan(4, 17, 25, 30), controladorContato.SelecionarPorId(contato.Id));

            //action
            controladorCompromisso.Editar(compromisso.Id, novoCompromisso);

            //assert
            Compromisso compromissoAtualizado = controladorCompromisso.SelecionarPorId(compromisso.Id);
            compromissoAtualizado.Should().Be(novoCompromisso);
        }

        [TestMethod]
        public void DeveAtualizar_Compromisso_ExcluindoContato()
        {
            //arrange
            Contato contato = new Contato("Rafaela", "rafa@gmail.com", "999121315", "ndd", "estagiária");
            controladorContato.InserirNovo(contato);

            Compromisso compromisso = new Compromisso("trabalho", "padaria", "", DateTime.Today,
                new TimeSpan(3, 17, 25, 30), new TimeSpan(4, 17, 25, 30), controladorContato.SelecionarPorId(contato.Id));

            controladorCompromisso.InserirNovo(compromisso);

            Compromisso novoCompromisso = new Compromisso("faculdade", "ifsc", "", DateTime.Today,
                new TimeSpan(13, 00, 00), new TimeSpan(14, 00, 00), null);           

            //action
            controladorCompromisso.Editar(compromisso.Id, novoCompromisso);

            //assert
            Compromisso compromissoAtualizado = controladorCompromisso.SelecionarPorId(compromisso.Id);
            compromissoAtualizado.Should().Be(novoCompromisso);
        }

        [TestMethod]
        public void DeveExcluir_UmCompromisso()
        {
            //arrange            
            Compromisso compromisso = new Compromisso("faculdade", "ifsc", "", DateTime.Today,
                new TimeSpan(13, 00, 00), new TimeSpan(14, 00, 00), null);
            controladorCompromisso.InserirNovo(compromisso);

            //action            
            controladorCompromisso.Excluir(compromisso.Id);

            //assert
            Compromisso tarefaEncontrada = controladorCompromisso.SelecionarPorId(compromisso.Id);
            tarefaEncontrada.Should().BeNull();
        }

        [TestMethod]
        public void DeveSelecionar_Compromisso_PorId()
        {
            //arrange
            Compromisso compromisso = new Compromisso("faculdade", "ifsc", "", DateTime.Today,
                new TimeSpan(13, 00, 00), new TimeSpan(14, 00, 00), null);
            
            controladorCompromisso.InserirNovo(compromisso);

            //action
            Compromisso compromissoEncontrado = controladorCompromisso.SelecionarPorId(compromisso.Id);

            //assert
            compromissoEncontrado.Should().NotBeNull();
        }

        [TestMethod]
        public void DeveSelecionar_TodosCompromissos()
        {
            //arrange
            Compromisso c1 = new Compromisso("faculdade", "ifsc", "", DateTime.Today,
                new TimeSpan(13, 00, 00), new TimeSpan(14, 00, 00), null);
            controladorCompromisso.InserirNovo(c1);

            Compromisso c2 = new Compromisso("trabalho", "ndd", "", DateTime.Today,
                new TimeSpan(15, 00, 00), new TimeSpan(16, 00, 00), null);
            controladorCompromisso.InserirNovo(c2);

            Compromisso c3 = new Compromisso("monitoria", "ifsc", "", DateTime.Today,
                new TimeSpan(17, 00, 00), new TimeSpan(18, 00, 00), null);
            controladorCompromisso.InserirNovo(c3);

            //action
            var compromissos = controladorCompromisso.SelecionarTodos();

            //assert
            compromissos.Should().HaveCount(3);
            compromissos[0].Assunto.Should().Be("faculdade");
            compromissos[1].Assunto.Should().Be("trabalho");
            compromissos[2].Assunto.Should().Be("monitoria");
        }

        [TestMethod]
        public void DeveSelecionar_CompromissosFuturos()
        {
            //arrange
            Compromisso c1 = new Compromisso("faculdade", "ifsc", "", DateTime.Today,
                new TimeSpan(13, 00, 00), new TimeSpan(14, 00, 00), null);
            controladorCompromisso.InserirNovo(c1);

            Compromisso c2 = new Compromisso("trabalho", "ndd", "", new DateTime(2021,07,20),
                new TimeSpan(15, 00, 00), new TimeSpan(16, 00, 00), null);
            controladorCompromisso.InserirNovo(c2);

            Compromisso c3 = new Compromisso("monitoria", "ifsc", "", new DateTime(2021, 07, 30),
                new TimeSpan(17, 00, 00), new TimeSpan(18, 00, 00), null);
            controladorCompromisso.InserirNovo(c3);

            //action
            var contatos = controladorCompromisso.SelecionarCompromissosFuturos(DateTime.Now, new DateTime(2021, 08, 01));

            //assert
            contatos.Should().HaveCount(2);
            contatos[0].Assunto.Should().Be("trabalho");
            contatos[1].Assunto.Should().Be("monitoria");
        }

        [TestMethod]
        public void DeveSelecionar_CompromissosPassados()
        {
            //arrange
            Compromisso c1 = new Compromisso("faculdade", "ifsc", "", DateTime.Today,
                new TimeSpan(13, 00, 00), new TimeSpan(14, 00, 00), null);
            controladorCompromisso.InserirNovo(c1);

            Compromisso c2 = new Compromisso("trabalho", "ndd", "", new DateTime(2021, 06, 20),
                new TimeSpan(15, 00, 00), new TimeSpan(16, 00, 00), null);
            controladorCompromisso.InserirNovo(c2);

            Compromisso c3 = new Compromisso("monitoria", "ifsc", "", new DateTime(2021, 06, 28),
                new TimeSpan(17, 00, 00), new TimeSpan(18, 00, 00), null);
            controladorCompromisso.InserirNovo(c3);

            //action
            var compromissos = controladorCompromisso.SelecionarCompromissosPassados(DateTime.Today);

            //assert
            compromissos.Should().HaveCount(2);
            compromissos[0].Assunto.Should().Be("trabalho");
            compromissos[1].Assunto.Should().Be("monitoria");
        }

    }
}

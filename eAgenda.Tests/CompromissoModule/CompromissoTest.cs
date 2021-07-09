using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using System;
using eAgenda.Dominio.CompromissoModule;
using eAgenda.Dominio.ContatoModule;

namespace eAgenda.Tests.CompromissosModule
{
    [TestClass]
    public class CompromissoTest
    {
        [TestMethod]
        public void DeveValidarAssunto()
        {
            //arrange
            var compromisso = new Compromisso("", "padaria", "meet.com", DateTime.Today, 
                new TimeSpan(3, 17, 25, 30), new TimeSpan(4, 17, 25, 30), new Contato("rafaela","rafaela@gmail", "999121315", "ndd", "estagiária"));

            //action
            var resultadoValidacao = compromisso.Validar();

            //assert
            resultadoValidacao.Should().Be("O campo Assunto é obrigatório");
        }

        [TestMethod]
        public void DeveValidarData()
        {
            //arrange
            var compromisso = new Compromisso("trabalho", "padaria", "meet.com", DateTime.MinValue,
                new TimeSpan(3, 17, 25, 30), new TimeSpan(4, 17, 25, 30), new Contato("rafaela", "rafaela@gmail", "999121315", "ndd", "estagiária"));

            //action
            var resultadoValidacao = compromisso.Validar();

            //assert
            resultadoValidacao.Should().Be("O campo Data é obrigatório");
        }

        [TestMethod]
        public void DeveValidarHoraInicio()
        {
            //arrange
            var compromisso = new Compromisso("trabalho", "padaria", "meet.com", DateTime.Today, 
                TimeSpan.MinValue, new TimeSpan(4, 17, 25, 30), new Contato("rafaela", "rafaela@gmail", "999121315", "ndd", "estagiária"));

            //action
            var resultadoValidacao = compromisso.Validar();

            //assert
            resultadoValidacao.Should().Be("O campo Hora Início é obrigatório");
        }

        [TestMethod]
        public void DeveValidarHoraTermino()
        {
            //arrange
            var compromisso = new Compromisso("trabalho", "padaria", "meet.com", DateTime.Today,
                new TimeSpan(4, 17, 25, 30), TimeSpan.MinValue, new Contato("rafaela", "rafaela@gmail", "999121315", "ndd", "estagiária"));

            //action
            var resultadoValidacao = compromisso.Validar();

            //assert
            resultadoValidacao.Should().Be("O campo Hora Término é obrigatório");
        }

        [TestMethod]
        public void DeveValidar_Assunto_Data()
        {
            //arrange
            var compromisso = new Compromisso("", "padaria", "meet.com", DateTime.MinValue,
                new TimeSpan(4, 17, 25, 30), new TimeSpan(4, 17, 25, 30), new Contato("rafaela", "rafaela@gmail", "999121315", "ndd", "estagiária"));

            //action
            var resultadoValidacao = compromisso.Validar();

            //assert
            var resultadoEsperado =
                "O campo Assunto é obrigatório"
                 + Environment.NewLine
                + "O campo Data é obrigatório";
            resultadoValidacao.Should().Be(resultadoEsperado);
        }

        [TestMethod]
        public void DeveValidar_HoraInicio_HoraTermino()
        {
            //arrange
            var compromisso = new Compromisso("trabalho", "padaria", "meet.com", DateTime.Today,
                TimeSpan.MinValue, TimeSpan.MinValue, new Contato("rafaela", "rafaela@gmail", "999121315", "ndd", "estagiária"));

            //action
            var resultadoValidacao = compromisso.Validar();

            //assert
            var resultadoEsperado =
                "O campo Hora Início é obrigatório"
                 + Environment.NewLine
                + "O campo Hora Término é obrigatório";
            resultadoValidacao.Should().Be(resultadoEsperado);
        }
    }
}

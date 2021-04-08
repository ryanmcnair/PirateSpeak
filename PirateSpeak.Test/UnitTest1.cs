using NUnit.Framework;
using System;
using Xunit;

namespace PirateSpeak.Test
{
    public class UnitTest1
    {
        [Fact]
        public void when_jumbledUpLetters_and_possibleWords_are_passed_in_theAnswer_should_pass_the_test()
        {
            //ARRANGE
            var jumbledUpLetters = "ortsp";
            string[] possibleWords = { "sport", "parrot", "ports", "matey" };
            string[] theAnswer = { "sport", "ports" };
            var compiler = new WordTranslator();

            //ACT
            var result = compiler.WordFinder(jumbledUpLetters, possibleWords);

            //ASSERT

            CollectionAssert.AreEquivalent(theAnswer, result);

        }
    }
}

﻿namespace StartUp
{
    class Startup
    {
        // Uncomment a test and run. 
        static void Main()
        {
            _01_StudentAssembly_Tests.BasicTests.TestEquals();
            _01_StudentAssembly_Tests.BasicTests.TestHash();
            _01_StudentAssembly_Tests.BasicTests.TestClone();
            _01_StudentAssembly_Tests.BasicTests.TestCompare();

            //_02_PersonAssembly_Tests.BasicTests.Test_01();

            //_03_BitArray64Assembly_Tests.BasicTests.Test_01();

            //_04_BinaryTree_Tests.BasicTest.Test_01();
            //_04_BinaryTree_Tests.TimedTests.TimeSearchListVTree();
            //_04_BinaryTree_Tests.TimedTests.TimeToGenerate();
        }
    }
}

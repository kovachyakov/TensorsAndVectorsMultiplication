using System;
using Tensors;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tensors.Tests
{
    [TestClass]
    public class Tests
    {

        #region//Scalar

        [TestMethod]
        public void ScalarVectorAndVector()
        {
            MyForm testClass = new MyForm();

            var a = new vector(-4, 3, 5);
            var b = new vector(1, 7, -6);

            var result = testClass.ScalarMultiplication(a, b);

            Assert.AreEqual(-13, result);

        }

        [TestMethod]
        public void ScalarVectorAndTensor()
        {
            MyForm testClass = new MyForm();

            var a = new vector(1, 0, 0);

            var A = new tensor(3, 4, 0, 
                               2, 0, 0, 
                               0, -5, 0);

            var result = testClass.ScalarMultiplication(a,A);

            Assert.AreEqual(new vector(3, 4, 0), result);

            var b = new vector(0, 1, 1);

            var B = new tensor(0, 0, 3,
                               0, 1, 2,
                               4, 0, -6);

            var result1 = testClass.ScalarMultiplication(b, B);

            Assert.AreEqual(new vector(4, 1, -4), result1);

        }

        [TestMethod]
        public void ScalarTensorAndVector()
        {
            MyForm testClass = new MyForm();

            var a = new vector(1, 0, 0);

            var A = new tensor(3, 4, 0,
                               2, 0, 0,
                               0, -5, 0);

            var result = testClass.ScalarMultiplication(A, a);

            Assert.AreEqual(new vector(3, 2, 0), result);


            var b = new vector(0, 1, 1);

            var B = new tensor(0, 0, 3,
                               0, 1, 2,
                               4, 0, -6);

            var result1 = testClass.ScalarMultiplication(B, b);

            Assert.AreEqual(new vector(3, 3, -6), result1);
        }

        [TestMethod]
        public void ScalarTensorAndTensor()
        {
            MyForm testClass = new MyForm();

            var A = new tensor(3, 4, 0,
                               2, 0, 0,
                               0, -5, 0);

            var B = new tensor(4, 0, -1,
                               1, -5, 0,
                               2, 0, 0);

            var result = testClass.ScalarMultiplication(A, B);

            Assert.AreEqual(new tensor(16, -20, -3,
                                       8, 0, -2,
                                       -5, 25, 0), result);

            var C = new tensor(0, 3, 0,
                              0, -2, 6,
                              7, 0, 1);

            var D = new tensor(0, -1, 0,
                               0, 0, 4,
                               0, 8, 6);

            var result1 = testClass.ScalarMultiplication(C, D);

            Assert.AreEqual(new tensor(0, 0, 12,
                                       0, 48, 28,
                                       0, 1, 6), result1);
        }

        #endregion

        #region//Vector

        [TestMethod]
        public void VectorVectorAndVector()
        {
            MyForm testClass = new MyForm();

            var a = new vector(-4, 3, 5);
            var b = new vector(1, 7, -6);

            var result = testClass.VectorMultiplication(a, b);

            Assert.AreEqual(new vector(-53,-19,-31),result);
        }

        [TestMethod]
        public void VectorVectorAndTensor()
        {
            MyForm testClass = new MyForm();

            var a = new vector(1, 0, 0);

            var A = new tensor(3, 4, 0,
                               2, 0, 0,
                               0, -5, 0);

            var result = testClass.VectorMultiplication(a, A);

            Assert.AreEqual(new tensor(0, 0, 0,
                                       0, 5, 0,
                                       2, 0, 0), result);

            var b = new vector(0, 1, 1);

            var B = new tensor(0, 0, 3,
                               0, 1, 2,
                               4, 0, -6);

            var result1 = testClass.VectorMultiplication(b, B);

            Assert.AreEqual(new tensor(4, -1, -8,
                                       0, 0, 3,
                                       0, 0, -3), result1);

        }

        [TestMethod]
        public void VectorTensorAndVector()
        {
            MyForm testClass = new MyForm();

            var a = new vector(1, 0, 0);

            var A = new tensor(3, 4, 0,
                               2, 0, 0,
                               0, -5, 0);

            var result = testClass.VectorMultiplication(A, a);

            Assert.AreEqual(new tensor(0, 0, -4,
                                       0, 0, 0,
                                       0, 0, 5), result);


            var b = new vector(0, 1, 1);

            var B = new tensor(0, 0, 3,
                               0, 1, 2,
                               4, 0, -6);

            var result1 = testClass.VectorMultiplication(B, b);

            Assert.AreEqual(new tensor(-3, 0, 0,
                                       -1, 0, 0,
                                       6, -4, 4), result1);

        }

        #endregion

        #region//TwiceMult

        [TestMethod]
        public void ScalarX2()
        {
            MyForm testClass = new MyForm();


            var A = new tensor(3, 4, 0,
                               2, 0, 0,
                               0, -5, 0);

            var B = new tensor(4, 0, -1,
                               1, -5, 0,
                               2, 0, 0);

            var C = new tensor(0, 0, 3,
                               0, -2, 6,
                               7, 0, 1);

            var D = new tensor(0, -1, 0,
                               0, 0, 4,
                               0, 8, 6);

            var result = testClass.TwiceScalar(A, B);
            var result1 = testClass.TwiceScalar(C, D);

            Assert.AreEqual(16, result);
            Assert.AreEqual(54, result1);
        }

        [TestMethod]
        public void ScalarVector()
        {
            MyForm testClass = new MyForm();


            var A = new tensor(3, 4, 0,
                               2, 0, 0,
                               0, -5, 0);

            var B = new tensor(4, 0, -1,
                               1, -5, 0,
                               2, 0, 0);

            var result = testClass.ScalarVector(A, B);

            Assert.AreEqual(new vector(-27, -2, -28), result);

            var C = new tensor(0, 3, 0,
                              0, -2, 6,
                              7, 0, 1);

            var D = new tensor(0, -1, 0,
                               0, 0, 4,
                               0, 8, 6);

            var result1 = testClass.ScalarVector(C, D);

            Assert.AreEqual(new vector(27, -12, 0), result1);
        }

        [TestMethod]
        public void VectorScalar()
        {
            MyForm testClass = new MyForm();


            var A = new tensor(3, 4, 0,
                               2, 0, 0,
                               0, -5, 0);

            var B = new tensor(4, 0, -1,
                               1, -5, 0,
                               2, 0, 0);

            var result = testClass.VectorScalar(A, B);

            Assert.AreEqual(new vector(8, -6, -28), result);

            var C = new tensor(0, 3, 0,
                              0, -2, 6,
                              7, 0, 1);

            var D = new tensor(0, -1, 0,
                               0, 0, 4,
                               0, 8, 6);

            var result1 = testClass.VectorScalar(C, D);

            Assert.AreEqual(new vector(-20, -48, 26), result1);
        }

        [TestMethod]
        public void VectorX2()
        {
            MyForm testClass = new MyForm();


            var A = new tensor(3, 4, 0,
                               2, 0, 0,
                               0, -5, 0);

            var B = new tensor(4, 0, -1,
                               1, -5, 0,
                               2, 0, 0);

            var result = testClass.TwiceVector(A, B);

            Assert.AreEqual(new tensor(0, 0, 0,
                                      -10, 0, 16,
                                       0, 4, -17), result);

            var C = new tensor(0, 3, 0,
                               0, -2, 6,
                               7, 0, 1);

            var D = new tensor(0, -1, 0,
                               0, 0, 4,
                               0, 8, 6);

            var result1 = testClass.TwiceVector(C, D);

            Assert.AreEqual(new tensor(-36, 57, 0,
                                       -18, 0, 0,
                                        24, 0, 3), result1);

        }

        [TestMethod]
        public void Trace()
        {
            MyForm testClass = new MyForm();

            var A = new tensor(3, 4, 0,
                               2, 0, 0,
                               0, -5, 0);

            var B = new tensor(4, 0, -1,
                               1, -5, 0,
                               2, 0, 0);

            var result = testClass.Trace(A);
            var result1 = testClass.Trace(B);

            Assert.AreEqual(3, result);
            Assert.AreEqual(-1, result1);
        }

        #endregion

        [TestMethod]
        public void DiadMultip()
        {
            MyForm testClass = new MyForm();

            var a = new vector(2, -1, 5);
            var b = new vector(4,  3, 7);

            var result = testClass.DiadMultiplication(a, b);

            Assert.AreEqual(new tensor(8, 6, 14, 
                                      -4, -3, -7,
                                      20, 15, 35), result);
        }

        [TestMethod]
        public void MixedMultip()
        {
            MyForm testClass = new MyForm();

            var a = new vector(2, -1, 5);
            var b = new vector(4, 3, 7);
            var c = new vector(9, -6, 2);

            var result = testClass.MixedMultiplication(a, b, c);

            Assert.AreEqual(-214, result);
        }

    }
}

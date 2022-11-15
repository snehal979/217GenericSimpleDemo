using FindMaxi;

namespace FindMaxNumTest
{
    public class Tests
    {
        FindMaxNum maxNum = new FindMaxNum();


        public void Givenmaxfirstname_whenanalysed_shouldreturnfistmax()
        {
            //AAA
            //arrage initializatiion of vaiables

            int result = maxNum.FindMaxValue(30, 2, 5);
            // act creation of object and calling particular 
            //assert validation the output
            Assert.AreEqual(30, result);
        }

        public void GivenmaxSecondname_whenanalysed_shouldreturnSecondmax()
        {

            int result = maxNum.FindMaxValue(3, 30, 5);
            Assert.AreEqual(30, result);
        }
        public void GivenmaxThirdname_whenanalysed_shouldreturnThirdmax()
        {

            int result = maxNum.FindMaxValue(3, 5, 30);
            Assert.AreEqual(30, result);
        }


        public void GivenmaxfirstFloatValue_whenanalysed_shouldreturnfistmax()
        {
            //AAA
            //arrage initializatiion of vaiables

            float result = maxNum.FindMaxFloatValue(30.7F, 2.7F, 5.4F);
            // act creation of object and calling particular 
            //assert validation the output
            Assert.AreEqual(30.7F, result);
        }

        public void GivenmaxSecondFloatValue_whenanalysed_shouldreturnSecondmax()
        {

            float result = maxNum.FindMaxFloatValue(2.7F, 30.7F, 5.4F);
            Assert.AreEqual(30.7F, result);
        }
        public void GivenmaxFloatValue_whenanalysed_shouldreturnThirdmax()
        {

            float result = maxNum.FindMaxFloatValue(2.7F, 5.4F, 30.7F);
            Assert.AreEqual(30.7F, result);
        }



        public void GivenmaxfirstStringValue_whenanalysed_shouldreturnfistmax()
        {
            //AAA
            //arrage initializatiion of vaiables

            string result = maxNum.FindMaxStringValue("Peach", "Apple", "Banana");
            // act creation of object and calling particular 
            //assert validation the output
            Assert.AreEqual("Peach", result);
        }
        public void GivenmaxSecondStringValue_whenanalysed_shouldreturnfistmax()
        {
            //AAA
            //arrage initializatiion of vaiables

            string result = maxNum.FindMaxStringValue("Apple", "Peach", "Banana");
            // act creation of object and calling particular 
            //assert validation the output
            Assert.AreEqual("Peach", result);
        }
        public void GivenmaxTHIRDStringValue_whenanalysed_shouldreturnfistmax()
        {
            //AAA
            //arrage initializatiion of vaiables

            string result = maxNum.FindMaxStringValue("Banana", "Apple", "Peach");
            // act creation of object and calling particular 
            //assert validation the output
            Assert.AreEqual("Peach", result);
        }


        // Class Generic Method for Test CASE

        FindMaxGeneric<int> genericInt = new FindMaxGeneric<int>();
        FindMaxGeneric<float> GenericFloat = new FindMaxGeneric<float>();
        FindMaxGeneric<string> genericString = new FindMaxGeneric<string>();

        public void GenericGivenmaxfirstname_whenanalysed_shouldreturnfistmax()
        {
           

            int result = genericInt.FindMax(30, 2, 5);
           
            Assert.AreEqual(30, result);
        }

        public void GenericGivenmaxSecondname_whenanalysed_shouldreturnSecondmax()
        {

            int result = genericInt.FindMax(3, 30, 5);
            Assert.AreEqual(30, result);
        }
        public void GenericGivenmaxThirdname_whenanalysed_shouldreturnThirdmax()
        {

            int result = genericInt.FindMax(3, 5, 30);
            Assert.AreEqual(30, result);
        }


        public void GenericGivenmaxfirstFloatValue_whenanalysed_shouldreturnfistmax()
        {
           

            float result = GenericFloat.FindMax(30.7F, 2.7F, 5.4F);
            
            Assert.AreEqual(30.7F, result);
        }

        public void GenericGivenmaxSecondFloatValue_whenanalysed_shouldreturnSecondmax()
        {

            float result = GenericFloat.FindMax(2.7F, 30.7F, 5.4F);
            Assert.AreEqual(30.7F, result);
        }
        public void GenericGivenmaxFloatValue_whenanalysed_shouldreturnThirdmax()
        {

            float result = GenericFloat.FindMax(2.7F, 5.4F, 30.7F);
            Assert.AreEqual(30.7F, result);
        }



        public void GenericGivenmaxfirstStringValue_whenanalysed_shouldreturnfistmax()
        {
           
            string result = genericString.FindMax("Peach", "Apple", "Banana");
            
            Assert.AreEqual("Peach", result);
        }
        public void GenericGivenmaxSecondStringValue_whenanalysed_shouldreturnfistmax()
        {
           

            string result = genericString.FindMax("Apple", "Peach", "Banana");
            
            
            Assert.AreEqual("Peach", result);
        }
        public void GenericGivenmaxTHIRDStringValue_whenanalysed_shouldreturnfistmax()
        {
            
            string result = genericString.FindMax("Banana", "Apple", "Peach");
            
            Assert.AreEqual("Peach", result);
        }


        // FOR mETHOD Generic Method Test Case
        // creat Object foe method

        FindMaxGenericMethod genericMethod = new FindMaxGenericMethod();


        public void GMethodGivenmaxfirstname_whenanalysed_shouldreturnfistmax()
        {


            int result = genericMethod.FindMax(30, 2, 5);

            Assert.AreEqual(30, result);
        }

        public void GMethodGivenmaxSecondname_whenanalysed_shouldreturnSecondmax()
        {

            int result = genericMethod.FindMax(3, 30, 5);
            Assert.AreEqual(30, result);
        }
        public void GMethodGivenmaxThirdname_whenanalysed_shouldreturnThirdmax()
        {

            int result = genericMethod.FindMax(3, 5, 30);
            Assert.AreEqual(30, result);
        }


        public void GMethodGivenmaxfirstFloatValue_whenanalysed_shouldreturnfistmax()
        {


            float result = genericMethod.FindMax(30.7F, 2.7F, 5.4F);

            Assert.AreEqual(30.7F, result);
        }

        public void GMethodGivenmaxSecondFloatValue_whenanalysed_shouldreturnSecondmax()
        {

            float result = genericMethod.FindMax(2.7F, 30.7F, 5.4F);
            Assert.AreEqual(30.7F, result);
        }
        public void GMethodGivenmaxFloatValue_whenanalysed_shouldreturnThirdmax()
        {

            float result = genericMethod.FindMax(2.7F, 5.4F, 30.7F);
            Assert.AreEqual(30.7F, result);
        }



        public void GMethodGivenmaxfirstStringValue_whenanalysed_shouldreturnfistmax()
        {

            string result = genericMethod.FindMax("Peach", "Apple", "Banana");

            Assert.AreEqual("Peach", result);
        }
        public void GMethodGivenmaxSecondStringValue_whenanalysed_shouldreturnfistmax()
        {


            string result = genericMethod.FindMax("Apple", "Peach", "Banana");


            Assert.AreEqual("Peach", result);
        }
        public void GMethodGivenmaxTHIRDStringValue_whenanalysed_shouldreturnfistmax()
        {

            string result = genericMethod.FindMax("Banana", "Apple", "Peach");

            Assert.AreEqual("Peach", result);
        }


    }
}
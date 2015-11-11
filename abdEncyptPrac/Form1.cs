/*
 * Name:Addison Dalton
 * Program: RSA Encryption Demo for Senior Math Project at Averett University Spring 2015
 * Goal: Demonstration program for RSA encryption. Uses actual equations used within real RSA algorithms and tyes
 * together many other areas of mathematics for the program to work. The program takes an original message from the user and encrypts
 * the message using a randomly generated 32bit integer or an integer entered by a user. The program displays the encrypted message (cipher text)
 * and also allows the user to decrypt the cipher text back into the original message.
 * Prof: Dr. Tucker
 * Date: Spring 2015
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using System.Security;

namespace abdEncyptPrac
{

    public partial class Form1 : Form
    {
        
        //VARIABLES
        string message;
        long[] msgArray; //array to hold encrypted characters
        long primeA = 0;  
        long primeB = 0;  
        Random randPrime = new Random();
        long N;
        long phiN;
        long e; 
        long d=0;

        //used in Milar-Rabin test
        bool isPrimeA = false;
        bool isPrimeB = false;

        //function sets up program. Calculates the needed variables and displays them on screen.
        void rsaPrepCalc()
        {
            //Display prime A and B on screen
            primeA = Convert.ToInt64(txtPrimeA.Text);
            primeB = Convert.ToInt64(txtPrimeB.Text);


            //(Step 1)-----calculate N 
            N = primeA * primeB;
            txtN.Text = Convert.ToString(N); //display N

            //(Step 2)-----calculate phiN 
            phiN = (primeA - 1) * (primeB - 1);
            txtPhiN.Text = Convert.ToString(phiN); //display phiN

            //(STEP 3) TO calculate e, 
            e = calcE(phiN);
            txtE.Text = Convert.ToString(e); //display e

            //(Step 4)-----calculate d 
            d = calcD(e, phiN);
            txtD.Text = Convert.ToString(d); //display d

            //finally we get our public and private keys
            //(e,n) is PUBLIC key and (d,n) is PRIVATE key
        }


        //probable primelity test. I sort of know what it's doing, not completely know how or why it works.
        public bool millerRabinPrimeTest(Int32 pTestPrime, int testCycles)
        {
            //if pTestPrime is even, it is obvious it will not be prime.
            if(pTestPrime % 2 == 0)
            {
                return false;
            }

            BigInteger minusPrime = pTestPrime - 1; //if pPrimeTest(or n) is prime, then n-1 is even and a composite (d)
            int varS = 0;
            //n-1 can be written as: 2^(s)*d
            //minusPrime is our d
            while(minusPrime % 2 == 0) //gives n-1 in terms of 2^(s)*d
            {
                minusPrime /= 2;   //d /=2
                varS += 1;         //inc s
            }

            Random randTestNumber = new Random();
            for (int j = 0; j < testCycles; j++) //
            {
                //generate a random test number of the range (2 through pTestPrime -2)
                long testNumber = randTestNumber.Next(2, pTestPrime - 2); //testNumber = a

                //a^(2^(0)*d) or just a^d mod n
                BigInteger modResult = BigInteger.ModPow(testNumber, minusPrime, pTestPrime);

                //if modresult = 1 or n-1 (pTestPrime) then find a new testNumber. 
                //this checks the first iteration of s = 0.
                if (modResult == 1 || modResult == pTestPrime - 1)
                {
                    continue;
                }

                //this checks for rest of s up to s-1.
                for (int i = 0; i < varS; i++)
                {
                    modResult = BigInteger.ModPow(modResult, 2, pTestPrime); //modresult = modresult^(2) mod n. 

                    if (modResult == 1) //if modresult equals one, then pTestPrime is composite. 
                    {
                        return false;
                    }
                    if (modResult == pTestPrime - 1)
                    {
                        break;
                    }
                }
                return false;  
            }
            return true;    //if the testPrime fails none of the composite check numbers, then it is probably prime.
        }




        //calculates e. 
        //Does so by continully incrementing incE, until incE and phi(n) have a GCD of 1. (They are co-prime)
        public long calcE(long pPhin)
        {
            long incE = 2;
            long resultGCD = calcGCD(incE, pPhin); //calls the GCD function.
            while(resultGCD!= 1)
            {
                incE++;
                resultGCD = calcGCD(incE, pPhin);
            }


            return incE;
        }

        //GCD remainder loop
        public long calcGCD(long valueA,long valueB)
        {
            long remainder;
            while(valueB != 0)
            {
                remainder = valueA % valueB;
                valueA = valueB;
                valueB = remainder;
            }
            return valueA;
        }

        //function to calculate d which is used with private ket of RSA encryption
        public long calcD(long pE, long pPhiN)
        {
            long calcD=1;

            //EXTEND EUCLIDEAN ALGORITHM 
            long varX = 0, oldVarX = 1, tempX;
            long varY = 1, oldVarY = 0, tempY;
            long remainder = pPhiN, oldRemainder = pE, tempRemainder; // e=a and pPhin=b
            long quotient = 0;

            while(remainder != 0)
            {
                quotient = oldRemainder / remainder;

                //remainder calc
                tempRemainder = remainder;
                remainder = oldRemainder - (quotient * remainder);
                oldRemainder = tempRemainder;

                //x calc
                tempX = varX;
                varX = oldVarX - (quotient * varX);
                oldVarX = tempX;

                //y calc
                tempY = varY;
                varY = oldVarY - (quotient * varY);
                oldVarY = tempY;
            }

            //if you get a negative result, just add the modulo to it. (pPhin)
            if(oldVarX < 0)
            {
                oldVarX += pPhiN;
            }

            calcD = oldVarX;
            return calcD;
        }

        //Takes the orginal message and encrypts it using e and N. 
        public BigInteger rsaEncryptCalc(long pMsg, long pE, long pN) //a message (char) is passed, a long with e and N.
        {
            BigInteger cypherMsg = BigInteger.ModPow(pMsg, pE, pN); //modular exponeciation 
            return cypherMsg;
        }

        //Takes the cypher message and decrypts it using d and N. Very similar to rsaEncryptCalc.
        public long rsaDecryptCalc(long pMsg, long pD, long pN)
        {
           BigInteger originalMsg = BigInteger.ModPow(pMsg, pD, pN);
           return (long) originalMsg;
        }


        //function takes a string converts to char[] and encrypts each character using the rsaEncryptCalc function
        void encryption(string pMessage)
        {  
            char[] msgToEncrypt = pMessage.ToCharArray(); //converts string from textbox to char array
            msgArray = new long[pMessage.Length]; //makes the array as long as message is.
            string cypherText = "";
            
            for(int j= 0; j < msgToEncrypt.Length; j++) //loops through the rest of characters in string, encrypting them
            {
                msgArray[j] = (long)rsaEncryptCalc(msgToEncrypt[j], e, N); //puts each encrypted character into the array
                cypherText += msgArray[j]; //ties together each encrypted chracter, to produce a pseudo cipher text 
            }
            
            txtEncryptedMsg.Text = cypherText;   //displays cipher text
        }


        //takes the encrypted cipher array, decrypts it using 'd', takes that value (which is an ascii val) and converts to a char. 
        void decryption()
        {
            string originalMSg = "";
            char asciiVal;

            //loop that takes each cipher character from the array and passes it through the decryption equation.
            for (int j = 0; j < msgArray.Length; j++)
            {
                asciiVal = Convert.ToChar(rsaDecryptCalc(msgArray[j], d, N));
                originalMSg += asciiVal; //ties together the message
            }
            originalMSg = txtDecryptedMsg.Text = originalMSg;
        }

       
        public Form1()
        {
            InitializeComponent();
        }

        //not sure why these form loads are here, but visual studio gets upset if I try to delete them.
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
           
        }

        //button press for encryption
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            rsaPrepCalc(); //prep calc, calculates n, phi of n, e and d.
            message = txtOriginalMsg.Text; //sets message to what the user entered
            encryption(message); //and passes it to the encryption function
        }


        //button press for decryption
        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            decryption();
        }

        //this is btnGenPrimes, it kept assigning this name and trying to screw up
        //program if I removed it. Very odd.
        private void button1_Click(object sender, EventArgs e)
        {
            isPrimeA = false; isPrimeB = false; //Added these so the checker would reset everytime someone wanted to generate a prime number
            //randomly finds 32 bit numbers, loops until one is prime. stores as primeA
            while (isPrimeA == false) //loops until a prime is found
            {
                primeA = randPrime.Next(Int16.MaxValue + 1, Int32.MaxValue); //assigns primaA an random 32bit integer
                isPrimeA = millerRabinPrimeTest((Int32)primeA, 5); //checks if said integer is prime

            }
            txtPrimeA.Text = Convert.ToString(primeA); //displays the prime

            //same thing as primeA
            while (isPrimeB == false)
            {
                primeB = randPrime.Next(Int16.MaxValue + 1, Int32.MaxValue);
                isPrimeB = millerRabinPrimeTest((Int32)primeB, 5);
            }
            txtPrimeB.Text = Convert.ToString(primeB); 
        }

        //this is chckExtraInfo, displays extra info such as N, Phi of N, public key and private key.
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(chckExtraInfo.Checked == true)
            {
                lblN.Visible = true; txtN.Visible = true; //N
                lblPhiN.Visible = true; txtPhiN.Visible = true; //Phi of N  
                lblE.Visible = true; txtE.Visible = true; //public key
                lblD.Visible = true; txtD.Visible = true; // Private key
            }
            else
            {
                lblN.Visible = false; txtN.Visible = false; //N
                lblPhiN.Visible = false; txtPhiN.Visible = false; //Phi of N  
                lblE.Visible = false; txtE.Visible = false; //public key
                lblD.Visible = false; txtD.Visible = false; // Private key
            }
        }

        //not used, but again... Visual studio gets mad if I delete it.
        private void grpExtraInfo_Enter(object sender, EventArgs e)
        {

        }
       
    }
}

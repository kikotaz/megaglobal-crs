﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace MegaGlobalCRS.Models
{
    /*
     * @ClassName: PasswordHasher
     * @Description: This class will be responsible for hashing sensetive data such as password
     * @Developer: Karim Saleh
     */
    public class PasswordHasher
    {
        /*
         * @Method: GetHashedPassword
         * @Params: string givenPassword, string email
         * @Return: string, will hold the value of the password after hashing
         * @Description: This method will accept both the password given by user, and his
         * userID, and will create salt from the userId string, then will create a hash 
         * from salted password (combining password and salt)
         */
        public string GetHashedPassword (string givenPassword, string userID)
        {
            HashAlgorithm algorithm = SHA1.Create();

            //creating byte array of the given password
            byte[] password = ASCIIEncoding.ASCII.GetBytes(givenPassword);

            //creating salt from the user's ID
            byte[] salt = ASCIIEncoding.ASCII.GetBytes(userID);

            //Applying salt to user's password
            byte[] saltedPassword = new byte[givenPassword.Length + salt.Length];

            //Hashing the salted password
            byte[] hashedPassword = algorithm.ComputeHash(saltedPassword);

            return Convert.ToBase64String(hashedPassword);
        }
    }
}
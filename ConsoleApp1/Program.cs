using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading;
using System.IO.Compression;
using System.Reflection;

/*
 * auto create
 *
 *
 *
 *
 */

namespace DECrypt_Suite
{
    class Program
    {
        private static bool file = false;
        private static bool folder = false;
        private static bool header = false;
        private static bool Hex = false;
        private static bool headeronly = false;
        private static bool decrypting = false;

        //private static string ip = "";
        private static string password = "";
        private static string filePath = "";
        private static string folderPath = "";
        private static string extenstion = "";
        private static string headerData = "";
        private static string output = "";

        private static string signing = DecryptMix(Properties.Settings.Default.U2lnbgqq); //those "random" stuff is just base64 encoding so nothing hard see encryptionmix and decryptiosmix
        /*
         *
         * Got those from Matt's(HackNet's Main Dev Source Code)
         * Sorry Matt <3
         *
         */
        private static string[] HeaderSplitDelimiters = new string[] { "::" };
        private static ushort GetPassCodeFromString(string code) => ((ushort)code.GetHashCode());
        public static string truebase64 = EncryptMix("true");
        public static string falsebase64 = EncryptMix("false");
        /*
        public static string FirstRunbase64 = EncryptMix("FirstRun").Replace('=', 'E');
        public static string Signbase64 = EncryptMix("Sign").Replace('=', 'q');
        */
        public static string[] robustNewlineDelim = new string[] { "\r\n", "\n" };using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading;
using System.IO.Compression;
using System.Reflection;

/*
 * auto create
 *
 *
 *
 *
 */

namespace DECrypt_Suite
{
    class Program
    {
        private static bool file = false;
        private static bool folder = false;
        private static bool header = false;
        private static bool Hex = false;
        private static bool crack = false;
        private static bool headeronly = false;
        private static bool decrypting = false;

        private static string passcode = "";
        private static string password = "";
        private static string filePath = "";
        private static string folderPath = "";
        private static string extenstion = "";
        private static string headerData = "";
        private static string output = "";

        private static string signing = DecryptMix(Properties.Settings.Default.U2lnbgqq); //those "random" stuff is just base64 encoding so nothing hard see encryptionmix and decryptiosmix
        /*
         *
         * Got those from Matt's(HackNet's Main Dev Source Code)
         * Sorry Matt <3
         *
         */
        private static string[] HeaderSplitDelimiters = new string[] { "::" };
        private static ushort GetPassCodeFromString(string code) => ((ushort)code.GetHashCode());
        public static string truebase64 = EncryptMix("true");
        public static string falsebase64 = EncryptMix("false");
        /*
        public static string FirstRunbase64 = EncryptMix("FirstRun").Replace('=', 'E');
        public static string Signbase64 = EncryptMix("Sign").Replace('=', 'q');
        */
        public static string[] robustNewlineDelim = new string[] { "\r\n", "\n" };
        public static char[] spaceDelim = new char[] { ' ' };
        public static string ApplicationName = "DECrypt Suite v1.337";

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Title = ApplicationName;

            var dir = AppDomain.CurrentDomain.BaseDirectory;
            if(!Directory.Exists(dir + "/files"))
            {
                Directory.CreateDirectory(dir + "/files");
            }

            /* Testing stuff

            string en = BitConverter.ToString(GetBinaryFile("files/input.zip"));
            en = EncryptString(en, signing, "Test .ZIP", "", ".gif");
            File.WriteAllText("files/output.dec", en);

            string raw = File.ReadAllText("files/output.dec");
            string[] de = DecryptString(raw, "");
            byte[] data = de[2].Split('-').Select(b => Convert.ToByte(b, 16)).ToArray();

            Console.WriteLine($"Header: {de[0]}");
            Console.WriteLine($"Signed by: {de[1]}");
            File.WriteAllBytes("files/output.zip", data);
            Console.WriteLine($"File Extension: {de[3]}");
            Console.WriteLine($"Password Valid: {de[4]}");

            Console.WriteLine("Press enter to Exit.");
            Console.ReadLine();


            string FolderPath = "C:\\Users\\justa\\Desktop\\Confuser";

            ZipFile.CreateFromDirectory(FolderPath, "C:\\Users\\justa\\Desktop\\test.zip");

            Exit();
            */

            // First start up shit ---------------------------------------------------------------------- \\

            if (DecryptMix(Properties.Settings.Default.Rmlyc3RSdW4E) == "true")
            {
                Console.WriteLine("First run detected, running startup sequence...");
                Console.WriteLine("Welcome to the " + ApplicationName + "encryption and decryption tool.");
                Console.WriteLine("We're gonna ask you a few questions now, press Enter when ready.");
                Console.ReadLine();
                Console.WriteLine("What should your signing be? Each file will be signed using that.");
                Console.WriteLine("Note: Try avoiding special characters and try to use an acronym linked to you which is somewhat known.");
                string sign = Console.ReadLine();
                Console.WriteLine($"Signing is set to '{sign}'. Is that correct? [Y/N]");
                string answer = Console.ReadLine().ToLower();
                if (answer == "y")
                {
                    Properties.Settings.Default.Rmlyc3RSdW4E = EncryptMix("false");
                    Properties.Settings.Default.U2lnbgqq = EncryptMix(sign);
                    Properties.Settings.Default.Save();
                    Properties.Settings.Default.Reload();

                    Console.WriteLine("Restarting in 3...");
                    Thread.Sleep(1000);
                    Console.WriteLine("2...");
                    Thread.Sleep(1000);
                    Console.WriteLine("1...");
                    Thread.Sleep(1000);
                    Console.WriteLine("69... hehexd");

                    Exit();
                }
                else if (answer == "n")
                {
                    Console.Write("Exiting now...");
                    for (int i = 0; i < 1500; i++)
                    {
                        Console.Write(".");
                        Thread.Sleep(1);
                    }
                    Exit();
                }
            }
            // ---------------------------------------------------------------------------------------- \\

            if (args.Length == 0)
            {
                Console.WriteLine("No arguments present.");
                Exit();
            }

            for (int i = 0; i < args.Count(); i++)
            {
                switch (args[i].ToLower())
                {
                    case "/?":
                    case "-h":
                    case "--help":
                        Help();
                        Exit();
                        break;
                    case "-c":
                    case "--credits":
                        Console.WriteLine("Made by @Kleberstoff with some \"borrowed\" Source Code from Matt (Hacknet's main developer)");
                        Console.WriteLine("This is based on the .DEC encryption from Hacknet and it is NOT really secure or effective.");
                        Console.WriteLine("It's been made only for fun and should be NEVER used for important files.");
                        Console.WriteLine("Thanks to trollbreeder#0369 for the wonderful name and A Casual Guy#0070 for testing, ya both are awesome.");
                        Console.WriteLine("\nBuy HackNet on Steam: http://store.steampowered.com/app/365450/");
                        Exit();
                        break;
                    case "--contact":
                        Console.WriteLine("You can contact me via Discord Kleberstoff#5914, or at admin@kleberstoff.xyz.");
                        break;
                    case "1337":
                        Console.WriteLine("Shotout to all HackNet Veterans. Ya'll are awesome.");
                        break;
                    case "-v":
                    case "--version":
                        Console.WriteLine("Current Version: 1.337-test");
                        Exit();
                        break;
                    case "-f":
                    case "--file":
                        file = true;
                        filePath = args[i + 1];
                        break;
                    case "-dir":
                    case "--directory":
                        folder = true;
                        folderPath = args[i + 1] + "\\";
                        break;
                    case "-p":
                    case "--password":
                        password = args[i + 1];
                        break;
                    case "-s":
                    case "--sign":
                        signing = args[i + 1];
                        break;
                    case "-o":
                    case "--output":
                        output = args[i + 1];
                        break;
                    case "-ex":
                    case "--extension":
                        extenstion = args[i + 1];
                        break;
                    case "-d":
                    case "--decrypt":
                        decrypting = true;
                        break;
                    case "-he":
                    case "--header":
                        header = true;
                        headerData = args[i + 1];
                        break;
                    case "-b":
                    case "--byte":
                        Hex = true;
                        break;
                    case "--headeronly":
                        headeronly = true;
                        break;
                    case "-phash":
                        passcode = args[i + 1];
                        break;
                    case "-dcrack":
                        crack = true;
                        break;
                    default:
                        break;
                }
            }


            if (decrypting && crack) //同时解密与破解
            {
                Console.WriteLine("Can't decrypt if cracking...");
                Exit();
            }

            if (folder&& (decrypting||crack))
            {
                Console.WriteLine("Folder Method is only for ENCRYPTION. Exiting...");
                Exit();
            }

            if (password != "" && passcode != "" && decrypting) //同时解密时同时使用Hash和密码
            {
                Console.WriteLine("Only use password or Hash of password...");
                Exit();
            }

            if (file || folder)
            {
                if (file && folder)
                {
                    Console.WriteLine("Do not use directory and file arguments in the same execution. Refer to --help dir. ");
                    Exit();
                }

                if (folder)
                {
                    if (folderPath != null && folderPath != "")
                    {
                        extenstion = ".zip";
                        if (output != "" && output != null)
                        {
                            ZipFile.CreateFromDirectory(folderPath, output + "temp.zip");
                            string Encryption = BitConverter.ToString(GetBinaryFile(output + "temp.zip"));
                            Encryption = EncryptString(Encryption, signing, headerData, password, extenstion);
                            File.WriteAllText(output + ".dec", Encryption);
                            Console.WriteLine($"Encryption of {folderPath} complete.");
                            Console.WriteLine("Deleting created temp.zip...");
                            File.Delete(output + "temp.zip");
                            Exit();
                        }
                        else
                        {
                            ZipFile.CreateFromDirectory(folderPath, "files/temp.zip");
                            string Encryption = BitConverter.ToString(GetBinaryFile("files/temp.zip"));
                            Encryption = EncryptString(Encryption, signing, headerData, password, extenstion);
                            File.WriteAllText("files/output.dec", Encryption);
                            Console.WriteLine($"Encryption of {folderPath} complete.");
                            Console.WriteLine("Deleting created temp.zip...");
                            File.Delete("files/temp.zip");
                            Exit();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid folder path");
                        Exit();
                    }
                }
                if (file)
                {
                    if (filePath != null && filePath != "")
                    {
                        if (headeronly == true)
                        {
                            string raw = File.ReadAllText(filePath);
                            string[] headerInfo = DecryptHeaders(raw);

                            Console.WriteLine("Header:\n");
                            Console.WriteLine($"Header: {headerInfo[0]}");
                            Console.WriteLine($"Signed by: {headerInfo[1]}");
                            Console.WriteLine($"File extension: {headerInfo[2]}");
                            Exit();
                        }

                        if (output != null && output != "")
                        {
                            if (decrypting)
                            {
                                string raw = File.ReadAllText(filePath);
                                string[] de = DecryptString(raw, password,passcode);
                                byte[] data;
                                if (Hex)
                                {
                                    data = de[2].Split('-').Select(b => Convert.ToByte(b, 16)).ToArray();
                                }
                                else
                                {
                                    data = System.Text.Encoding.Default.GetBytes(de[2]);
                                }

                                Console.WriteLine($"Header: {de[0]}");
                                Console.WriteLine($"Signed by: {de[1]}");
                                File.WriteAllBytes("files/output" + de[3], data);
                                Console.WriteLine($"File extension: {de[3]}");
                                Console.WriteLine($"Password valid: {de[4]}");
                                Exit();
                            }
                            else
                            {
                                if(crack)
                                {
                                    string raw = File.ReadAllText(filePath);
                                    string[] de = DecryptString(raw, password, Crack(raw));
                                    byte[] data;
                                    if (Hex)
                                    {
                                        data = de[2].Split('-').Select(b => Convert.ToByte(b, 16)).ToArray();
                                    }
                                    else
                                    {
                                        data = System.Text.Encoding.Default.GetBytes(de[2]);
                                    }

                                    Console.WriteLine($"Header: {de[0]}");
                                    Console.WriteLine($"Signed by: {de[1]}");
                                    File.WriteAllBytes("files/output" + de[3], data);
                                    Console.WriteLine($"File extension: {de[3]}");
                                    Console.WriteLine($"Password valid: {de[4]}");
                                    Exit();
                                }
                                else
                                {
                                    if (headerData != "" && headerData != null)
                                    {
                                        string Encryption = "";
                                        if (Hex)
                                        {
                                            Encryption = BitConverter.ToString(GetBinaryFile(filePath));
                                        }
                                        else
                                        {
                                            Encryption = File.ReadAllText(filePath);
                                        }
                                        Encryption = EncryptString(Encryption, signing, headerData, password, extenstion);
                                        File.WriteAllText(output + ".dec", Encryption);
                                        Console.WriteLine($"Encryption of {filePath} complete.");
                                        Exit();
                                    }
                                    else
                                    {
                                        Console.WriteLine("No header data found, aborting.");
                                        Exit();
                                    }
                                }
                            }
                        }
                        else
                        {
                            if (decrypting == true)
                            {
                                string raw = File.ReadAllText(filePath);
                                string[] de = DecryptString(raw, password,passcode);
                                byte[] data = null ;
                                if (Hex)
                                {
                                    data = de[2].Split('-').Select(b => Convert.ToByte(b, 16)).ToArray();
                                }
                                else
                                {
                                    if (de[2] != null && de[2] != "")
                                    {
                                        data = System.Text.Encoding.Default.GetBytes(de[2]);
                                    }
                                    else
                                    {
                                        if (passcode == "" && password == "")
                                        {
                                            Console.WriteLine("This File Requires a Password");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Provided Password Is Incorrect");
                                        }
                                        Exit();
                                    }
                                }

                                Console.WriteLine($"Header: {de[0]}");
                                Console.WriteLine($"Signed by: {de[1]}");
                                File.WriteAllBytes("files/output" + de[3], data);
                                Console.WriteLine($"File extension: {de[3]}");
                                Console.WriteLine($"Password valid: {de[4]}");
                                Exit();
                            }
                            else
                            {
                                if (crack == true)
                                {
                                    string raw = File.ReadAllText(filePath);
                                    string[] de = DecryptString(raw, password, Crack(raw));
                                    byte[] data;
                                    if (Hex)
                                    {
                                        data = de[2].Split('-').Select(b => Convert.ToByte(b, 16)).ToArray();
                                    }
                                    else
                                    {
                                        data = System.Text.Encoding.Default.GetBytes(de[2]);
                                    }

                                    Console.WriteLine($"Header: {de[0]}");
                                    Console.WriteLine($"Signed by: {de[1]}");
                                    File.WriteAllBytes("files/output" + de[3], data);
                                    Console.WriteLine($"File extension: {de[3]}");
                                    Console.WriteLine($"Password valid: {de[4]}");
                                    Exit();
                                }
                                else
                                {
                                    if (headerData != "" && headerData != null)
                                    {
                                        string Encryption = "";
                                        if (Hex)
                                        {
                                            Encryption = BitConverter.ToString(GetBinaryFile(filePath));
                                        }
                                        else
                                        {
                                            Encryption = File.ReadAllText(filePath);
                                        }
                                        Encryption = EncryptString(Encryption, signing, headerData, password, extenstion);
                                        File.WriteAllText("files/output.dec", Encryption);
                                        Console.WriteLine($"Encryption of {folderPath} complete.");
                                        Exit();
                                    }
                                    else
                                    {
                                        Console.WriteLine("No Header data found, aborting.");
                                        Exit();
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid file path");
                        Exit();
                    }
                }
            }
            else
            {
                Console.WriteLine("Didn't specify the folder/file path.");
                Exit();
            }
            
            Exit(null, null);
        }

        ///summary
        ///
        /// Returns an array containing
        /// [0] Header Message
        /// [1] Signing
        /// [2] Message Data
        /// [3] File extension if provided, else null
        /// [4] "1" is password is valid, "0" if not
        ///
        ///summary

        private static string[] DecryptString(string data, string pass = "",string strPasscode = "")
        {
            string[] ret = new string[5];
            ushort passcode = GetPassCodeFromString(pass);
            if (strPasscode != "")
            {
                passcode = ushort.Parse(strPasscode);
            }

            ushort emptypasscode = GetPassCodeFromString("");

            string[] split = data.Split(robustNewlineDelim, StringSplitOptions.RemoveEmptyEntries);
            if (split.Length < 2) throw new FormatException("Tried to decrypt an invalid valid DEC ENC file, aborting.");
            string[] headersSplit = split[0].Split(HeaderSplitDelimiters, StringSplitOptions.None);
            if (headersSplit.Length < 4) throw new FormatException("Tried to decrypt an invalid valid DEC ENC file, aborting.");

            string headerMsg = Decrypt(headersSplit[1], emptypasscode);
            string sign = Decrypt(headersSplit[2], emptypasscode);
            string check = Decrypt(headersSplit[3], passcode);
            string fileExtension = null;
            if (headersSplit.Length > 4) fileExtension = Decrypt(headersSplit[4], emptypasscode);
            string message;
            string passValid = "true";

            if (check == "ENCODED")
            {
                message = Decrypt(split[1], passcode);
            }
            else
            {
                headerMsg = null;
                sign = null;
                message = null;
                passValid = "false";
            }

            ret[0] = headerMsg;
            ret[1] = sign;
            ret[2] = message;
            ret[3] = fileExtension;
            ret[4] = passValid;
            return ret;
        }

        public static string[] DecryptHeaders(string data, string pass = "")
        {
            string[] strArray = new string[3];
            ushort passCodeFromString = GetPassCodeFromString(pass);
            string[] strArray2 = data.Split(robustNewlineDelim, StringSplitOptions.RemoveEmptyEntries);
            if (strArray2.Length < 2)
            {
                Console.WriteLine("Tried to decrypt an invalid valid DEC ENC file, aborting.");
                Exit();
            }
            string[] strArray3 = strArray2[0].Split(HeaderSplitDelimiters, StringSplitOptions.None);
            if (strArray3.Length < 4)
            {
                Console.WriteLine("Tried to decrypt an invalid valid DEC ENC file, aborting.");
                Exit();
            }
            string str = Decrypt(strArray3[1], passCodeFromString);
            string str2 = Decrypt(strArray3[2], passCodeFromString);
            string str3 = null;
            if (strArray3.Length > 4)
            {
                str3 = Decrypt(strArray3[4], passCodeFromString);
            }
            strArray[0] = str;
            strArray[1] = str2;
            strArray[2] = str3;
            return strArray;
        }

        private static string Decrypt(string data, ushort passcode)
        {
            StringBuilder builder = new StringBuilder();
            string[] strArray = data.Split(spaceDelim, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < strArray.Length; i++)
            {
                int num2 = Convert.ToInt32(strArray[i]);
                int num3 = 0x7fff;
                int num4 = (num2 - num3) - passcode;
                num4 /= 0x71e;
                builder.Append((char)num4);
            }
            return builder.ToString().Trim();
        }

        //↑↑ Decrypt ↑↑\\
        //=============\\
        //↓↓ Encrypt ↓↓\\

        public static string EncryptString(string data, string Sign, string header = null, string pass = "", string fileExtension = null)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("REMEMBER: THIS IS NOT A REAL, SAFE ENCRYPTION!");
            Console.WriteLine("USE AT YOUR OWN RISK! YOU HAVE BEEN WARNED.\n");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Note: This may take a long time.");

            ushort passCodeFromString = GetPassCodeFromString(pass);
            ushort passcode = GetPassCodeFromString("");
            StringBuilder builder = new StringBuilder();

            string str = "#DEC_ENC::" + Encrypt(header, passcode) + "::" + Encrypt(Sign, passcode) + "::" + Encrypt("ENCODED", passCodeFromString);
            if (fileExtension != null)
            {
                str = str + "::" + Encrypt(fileExtension, passcode);
            }
            builder.Append(str);
            builder.Append("\r\n");
            builder.Append(Encrypt(data, passCodeFromString));
            return builder.ToString();
        }

        private static string Encrypt(string data, ushort passcode)
        {
            StringBuilder ret = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                int newVal = ((ushort)data[i] * 1822) + ushort.MaxValue / 2 + passcode;
                ret.Append(newVal + " ");
            }
            return ret.ToString().Trim();
        }

        //↑↑ Encrypt ↑↑\\
        //=============\\
        //↓↓ Crack   ↓↓\\

        public static string Crack(string data)
        {
            string[] strArray2 = data.Split(robustNewlineDelim, StringSplitOptions.RemoveEmptyEntries);
            if (strArray2.Length < 2)
            {
                Console.WriteLine("Tried to decrypt an invalid valid DEC ENC file, aborting.");
                Exit();
            }
            string[] strArray3 = strArray2[0].Split(HeaderSplitDelimiters, StringSplitOptions.None);
            if (strArray3.Length < 4)
            {
                Console.WriteLine("Tried to decrypt an invalid valid DEC ENC file, aborting.");
                Exit();
            }
            string iData = "ENCODED";
            ushort oldVal = 0;
            string[] strArray4 = strArray3[3].Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < iData.Length; i++)
            {
                ushort newVal = (ushort)(int.Parse(strArray4[i]) - (ushort.MaxValue / 2) - (iData[i] * 1822));
                if(i != 0 && oldVal != newVal)
                {
                    Console.WriteLine("Cracking fail");
                    Exit();
                }
                oldVal = newVal;
            }
            return oldVal.ToString();
        }

        // MY RANDOM STUFF \\

        private static byte[] GetBinaryFile(string Path)
        {
            byte[] bytes;
            using (FileStream file = new FileStream(Path, FileMode.Open, FileAccess.Read))
            {
                bytes = new byte[file.Length];
                file.Read(bytes, 0, (int)file.Length);
            }
            return bytes;
        }

        private static string EncryptMix(string String)
        {
            if(String == null)
            {
                throw new ArgumentNullException();
            }

            byte[] plainTextBytes = System.Text.Encoding.UTF8.GetBytes(String);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        private static string DecryptMix(string String)
        {
            if (String == null)
            {
                throw new ArgumentNullException();
            }

            byte[] base64EncodedBytes = System.Convert.FromBase64String(String);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }

        static void Help(string LanguageCode = "",string command = "")
        {
            //语言设定
            string[] zh_CN_Help =
            {
                "加密或解密DEC文件",
                "",
                "DECryptSuite [-c] [-d : -dcrack] [-f : -dir] Source [-a : -b] [-o] Destination [-p : -phash] Password [-he] Header [-s] Sign [-ex] Extenstion [-h]",
                "",
                "默认是加密文件，如果要解密请添加-d或--decrypt",
                "更使用信息 --help <command>",
                "大多数命令都可以使用短参数及其较长的参数执行，例如c/credits。（WeiAI：我把长参数都隐藏了#滑稽）",
                "-f (--file) / -dir (--folder), -he(--header) 都是必要的参数（-he只有加密时是必要的）",
                "",
                "命令列表:",
                "  -c\t\t\t关于",
                "  -d\t\t\t解密指定Dec文件",
                "  -dcrack\t\t破解指定Dec文件",
                "  -f\t\t\t目标是文件",
                "  -dir\t\t\t目标是目录.",
                "  Source\t\t被指定的文件/目录.",
                "  -a\t\t\t表示一个 ASCII 文本文件。（以ASCII解密/加密）",
                "  -b\t\t\t表示一个二进位文件。（以byte解密/加密）",
                "  -o\t\t\t设定输出目标.",
                "  Destination\t\t输出文件",
                "  -p\t\t\t设定一个密码去加密/解密文件",
                "  -phash\t\t使用Hash去解密Dec文件（只能解密）",
                "  Password\t\t密码/Hash",
                "  -he\t\t\t设置文件头（只能用于加密）",
                "  Header\t\t文件头",
                "  -s\t\t\t设置文件签名（即来源IP）（只能用于加密）",
                "  Sign\t\t\t签名/来源IP",
                "  -ex\t\t\t设置文件扩展名（只能用于加密）",
                "  Extenstion\t\t扩展名（例如.txt .zip）",
                "  --contact\t\t现实我的联系方式.",
                "  --headeronly\t\tOnly decrypts the header of a file.（这个有点问题）"
            };

            string[] en_US_Help =
            {
                "Help for the DECryptSuite:",
                "",
                "The default mode is Encryption; to decrypt use argument -d or --decrypt",
                "For more information use --help <command>(c/f etc)",
                "Most commands can be executed with -c and their longer version --credits for example.",
                "-f (--file) / -dir (--folder), -he(--header) are required arguments.",
                "",
                "List of all commands:",
                "-c/--credits: Shows the credits.",
                "-f/--file: Selects a file from a specified path.",
                "-dir/--directory: Selects a directory from a specified path.",
                "-p/--password: Sets a password for encrypting/decrypting the files.",
                "-phash: Use the Hash to decrypt.(Only decrypt!)",
                "-dcrack: Crack the dec(it is Experimental function)",
                "-ex/--extension: Sets the file extenstion. Example: -ex .txt",
                "-he/--header: Sets the file header.",
                "-b: Read the file by byte or decrypt by byte",
                "-s/--sign: Sets the file sign",
                "-o/--output: Sets the output directory.",
                "--contact: Shows my contact information.",
                "--headeronly: Only decrypts the header of a file."
        };

            if (LanguageCode == "")//默认语言
                LanguageCode = System.Threading.Thread.CurrentThread.CurrentCulture.Name;


            switch(LanguageCode)
            {
                case "zh-CN":
                    for (int i = 0; i < zh_CN_Help.Length; i++)
                        Console.WriteLine(zh_CN_Help[i]);
                    break;
                case "en_US":
                    for (int i = 0; i < en_US_Help.Length; i++)
                        Console.WriteLine(en_US_Help[i]);
                    break;
                default:
                    for (int i = 0; i < en_US_Help.Length; i++)
                        Console.WriteLine(en_US_Help[i]);
                    break;
            }
        }

        static void Exit(object sender = null, EventArgs e = null)
        {
            Console.ResetColor();
            Environment.Exit(0);
        }
    }
}

        public static char[] spaceDelim = new char[] { ' ' };
        public static string ApplicationName = "DECrypt Suite v1.337";

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Title = ApplicationName;

            var dir = AppDomain.CurrentDomain.BaseDirectory;
            if(!Directory.Exists(dir + "/files"))
            {
                Directory.CreateDirectory(dir + "/files");
            }

            /* Testing stuff

            string en = BitConverter.ToString(GetBinaryFile("files/input.zip"));
            en = EncryptString(en, signing, "Test .ZIP", "", ".gif");
            File.WriteAllText("files/output.dec", en);

            string raw = File.ReadAllText("files/output.dec");
            string[] de = DecryptString(raw, "");
            byte[] data = de[2].Split('-').Select(b => Convert.ToByte(b, 16)).ToArray();

            Console.WriteLine($"Header: {de[0]}");
            Console.WriteLine($"Signed by: {de[1]}");
            File.WriteAllBytes("files/output.zip", data);
            Console.WriteLine($"File Extension: {de[3]}");
            Console.WriteLine($"Password Valid: {de[4]}");

            Console.WriteLine("Press enter to Exit.");
            Console.ReadLine();


            string FolderPath = "C:\\Users\\justa\\Desktop\\Confuser";

            ZipFile.CreateFromDirectory(FolderPath, "C:\\Users\\justa\\Desktop\\test.zip");

            Exit();
            */

            // First start up shit ---------------------------------------------------------------------- \\

            if (DecryptMix(Properties.Settings.Default.Rmlyc3RSdW4E) == "true")
            {
                Console.WriteLine("First run detected, running startup sequence...");
                Console.WriteLine("Welcome to the " + ApplicationName + "encryption and decryption tool.");
                Console.WriteLine("We're gonna ask you a few questions now, press Enter when ready.");
                Console.ReadLine();
                Console.WriteLine("What should your signing be? Each file will be signed using that.");
                Console.WriteLine("Note: Try avoiding special characters and try to use an acronym linked to you which is somewhat known.");
                string sign = Console.ReadLine();
                Console.WriteLine($"Signing is set to '{sign}'. Is that correct? [Y/N]");
                string answer = Console.ReadLine().ToLower();
                if (answer == "y")
                {
                    Properties.Settings.Default.Rmlyc3RSdW4E = EncryptMix("false");
                    Properties.Settings.Default.U2lnbgqq = EncryptMix(sign);
                    Properties.Settings.Default.Save();
                    Properties.Settings.Default.Reload();

                    Console.WriteLine("Restarting in 3...");
                    Thread.Sleep(1000);
                    Console.WriteLine("2...");
                    Thread.Sleep(1000);
                    Console.WriteLine("1...");
                    Thread.Sleep(1000);
                    Console.WriteLine("69... hehexd");

                    Exit();
                }
                else if (answer == "n")
                {
                    Console.Write("Exiting now...");
                    for (int i = 0; i < 1500; i++)
                    {
                        Console.Write(".");
                        Thread.Sleep(1);
                    }
                    Exit();
                }
            }
            // ---------------------------------------------------------------------------------------- \\

            if (args.Length == 0)
            {
                Console.WriteLine("No arguments present.");
                Exit();
            }

            for (int i = 0; i < args.Count(); i++)
            {
                switch (args[i].ToLower())
                {
                    case "-h":
                        Console.WriteLine("Help for the DECryptSuite:\n");
                        Console.WriteLine("The default mode is Encryption; to decrypt use argument -d or --decrypt");
                        Console.WriteLine("For more information use --help <command>(c/f etc)");
                        Console.WriteLine("Most commands can be executed with -c and their longer version --credits for example.");
                        Console.WriteLine("-f (--file) / -dir (--folder), -he(--header) are required arguments.");
                        Console.WriteLine("\nList of all commands:");
                        Console.WriteLine("-c/--credits: Shows the credits.");
                        Console.WriteLine("-f/--file: Selects a file from a specified path.");
                        Console.WriteLine("-dir/--directory: Selects a directory from a specified path.");
                        Console.WriteLine("-p/--password: Sets a password for encrypting/decrypting the files.");
                        Console.WriteLine("-ex/--extension: Sets the file extenstion. Example: -ex .txt");
                        Console.WriteLine("-he/--header: Sets the file header.");
                        Console.WriteLine("-Hex: Read the file by Hex");
                        Console.WriteLine("-s/--sign: Sets the file sign");
                        Console.WriteLine("-o/--output: Sets the output directory.");
                        Console.WriteLine("--contact: Shows my contact information.");
                        Console.WriteLine("--headeronly: Only decrypts the header of a file.");
                        Exit();
                        break;
                    case "--help":
                        Console.WriteLine("Help for the DECryptSuite:\n");
                        Console.WriteLine("The default mode is Encryption; to decrypt use argument -d or --decrypt");
                        Console.WriteLine("For more information use --help <command>(c/f etc)");
                        Console.WriteLine("Most commands can be executed with -c and their longer version --credits for example.");
                        Console.WriteLine("-f (--file) / -dir (--folder), -he(--header) are required arguments.");
                        Console.WriteLine("\nList of all commands:");
                        Console.WriteLine("-c/--credits: Shows the credits.");
                        Console.WriteLine("-f/--file: Selects a file from a specified path.");
                        Console.WriteLine("-dir/--directory: Selects a directory from a specified path.");
                        Console.WriteLine("-p/--password: Sets a password for encrypting/decrypting the files.");
                        Console.WriteLine("-ex/--extension: Sets the file extenstion. Example: -ex .txt");
                        Console.WriteLine("-he/--header: Sets the file header.");
                        Console.WriteLine("-Hex: Read the file by Hex");
                        Console.WriteLine("-s/--sign: Sets the file sign");
                        Console.WriteLine("-o/--output: Sets the output directory.");
                        Console.WriteLine("--contact: Shows my contact information.");
                        Console.WriteLine("--headeronly: Only decrypts the header of a file.");
                        Exit();
                        break;
                    case "-c":
                        Console.WriteLine("Made by @Kleberstoff with some \"borrowed\" Source Code from Matt (Hacknet's main developer)");
                        Console.WriteLine("This is based on the .DEC encryption from Hacknet and it is NOT really secure or effective.");
                        Console.WriteLine("It's been made only for fun and should be NEVER used for important files.");
                        Console.WriteLine("Thanks to trollbreeder#0369 for the wonderful name and A Casual Guy#0070 for testing, ya both are awesome.");
                        Console.WriteLine("\nBuy HackNet on Steam: http://store.steampowered.com/app/365450/");
                        Exit();
                        break;
                    case "--credits":
                        Console.WriteLine("Made by @Kleberstoff with some \"borrowed\" Source Code from Matt (Hacknet's main developer)");
                        Console.WriteLine("This is based on the .DEC encryption from Hacknet and it is NOT really secure or effective.");
                        Console.WriteLine("It's been made only for fun and should be NEVER used for important files.");
                        Console.WriteLine("Thanks to trollbreeder#0369 for the wonderful name and A Casual Guy#0070 for testing, ya both are awesome.");
                        Console.WriteLine("\nBuy HackNet on Steam: http://store.steampowered.com/app/365450/");
                        Exit();
                        break;
                    case "--contact":
                        Console.WriteLine("You can contact me via Discord Kleberstoff#5914, or at admin@kleberstoff.xyz.");
                        break;
                    case "1337":
                        Console.WriteLine("Shotout to all HackNet Veterans. Ya'll are awesome.");
                        break;
                    case "-v":
                        Console.WriteLine("Current Version: 1.337");
                        Exit();
                        break;
                    case "--version":
                        Console.WriteLine("Current Version: 1.337");
                        Exit();
                        break;
                    case "-f":
                        file = true;
                        filePath = args[i + 1];
                        break;
                    case "--file":
                        file = true;
                        filePath = args[i + 1];
                        break;
                    case "-dir":
                        folder = true;
                        folderPath = args[i + 1] + "\\";
                        break;
                    case "--directory":
                        folder = true;
                        folderPath = args[i + 1] + "\\";
                        break;
                    case "-p":
                        password = args[i + 1];
                        break;
                    case "-s":
                        signing = args[i + 1];
                        break;
                    case "--sign":
                        signing = args[i + 1];
                        break;
                    case "--password":
                        password = args[i + 1];
                        break;
                    case "-e":
                        extenstion = args[i + 1];
                        break;
                    case "-o":
                        output = args[i + 1];
                        break;
                    case "--output":
                        output = args[i + 1];
                        break;
                    case "-ex":
                        extenstion = args[i + 1];
                        break;
                    case "--extension":
                        extenstion = args[i + 1];
                        break;
                    case "-d":
                        decrypting = true;
                        break;
                    case "--decrypt":
                        decrypting = true;
                        break;
                    case "-he":
                        header = true;
                        headerData = args[i + 1];
                        break;
                    case "-Hex":
                        Hex = true;
                        break;
                    case "--header":
                        header = true;
                        headerData = args[i + 1];
                        break;
                    case "--headeronly":
                        headeronly = true;
                        break;
                    default:
                        break;
                }
            }

            if (folder == true && decrypting == true)
            {
                Console.WriteLine("Folder Method is only for ENCRYPTION. Exiting...");
                Exit();
            }

            if (file == true || folder == true)
            {
                if (file == true && folder == true)
                {
                    Console.WriteLine("Do not use directory and file arguments in the same execution. Refer to --help dir. ");
                    Exit();
                }

                if (folder == true)
                {
                    if (folderPath != null && folderPath != "")
                    {
                        extenstion = ".zip";
                        if (output != "" && output != null)
                        {
                            ZipFile.CreateFromDirectory(folderPath, output + "temp.zip");
                            string Encryption = BitConverter.ToString(GetBinaryFile(output + "temp.zip"));
                            Encryption = EncryptString(Encryption, signing, headerData, password, extenstion);
                            File.WriteAllText(output + ".dec", Encryption);
                            Console.WriteLine($"Encryption of {folderPath} complete.");
                            Console.WriteLine("Deleting created temp.zip...");
                            File.Delete(output + "temp.zip");
                            Exit();
                        }
                        else
                        {
                            ZipFile.CreateFromDirectory(folderPath, "files/temp.zip");
                            string Encryption = BitConverter.ToString(GetBinaryFile("files/temp.zip"));
                            Encryption = EncryptString(Encryption, signing, headerData, password, extenstion);
                            File.WriteAllText("files/output.dec", Encryption);
                            Console.WriteLine($"Encryption of {folderPath} complete.");
                            Console.WriteLine("Deleting created temp.zip...");
                            File.Delete("files/temp.zip");
                            Exit();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid folder path");
                        Exit();
                    }
                }
                if (file == true)
                {
                    if (filePath != null && filePath != "")
                    {
                        if (headeronly == true)
                        {
                            string raw = File.ReadAllText(filePath);
                            string[] headerInfo = DecryptHeaders(raw);

                            Console.WriteLine("Header:\n");
                            Console.WriteLine($"Header: {headerInfo[0]}");
                            Console.WriteLine($"Signed by: {headerInfo[1]}");
                            Console.WriteLine($"File extension: {headerInfo[2]}");
                            Exit();
                        }

                        if (output != null && output != "")
                        {
                            if (decrypting == true)
                            {
                                string raw = File.ReadAllText(filePath);
                                string[] de = DecryptString(raw, password);
                                byte[] data = de[2].Split('-').Select(b => Convert.ToByte(b, 16)).ToArray();

                                Console.WriteLine($"Header: {de[0]}");
                                Console.WriteLine($"Signed by: {de[1]}");
                                File.WriteAllBytes("files/output" + de[3], data);
                                Console.WriteLine($"File extension: {de[3]}");
                                Console.WriteLine($"Password valid: {de[4]}");
                                Exit();
                            }
                            else
                            {
                                if (headerData != "" && headerData != null)
                                {
                                    string Encryption = "";
                                    if (Hex)
                                    {
                                        Encryption = BitConverter.ToString(GetBinaryFile(filePath));
                                    }
                                    else
                                    {
                                        Encryption = File.ReadAllText(filePath);
                                    }
                                    Encryption = EncryptString(Encryption, signing, headerData, password, extenstion);
                                    File.WriteAllText(output + ".dec", Encryption);
                                    Console.WriteLine($"Encryption of {filePath} complete.");
                                    Exit();
                                }
                                else
                                {
                                    Console.WriteLine("No header data found, aborting.");
                                    Exit();
                                }
                            }
                        }
                        else
                        {
                            if (decrypting == true)
                            {
                                string raw = File.ReadAllText(filePath);
                                string[] de = DecryptString(raw, password);
                                byte[] data = de[2].Split('-').Select(b => Convert.ToByte(b, 16)).ToArray();

                                Console.WriteLine($"Header: {de[0]}");
                                Console.WriteLine($"Signed by: {de[1]}");
                                File.WriteAllBytes("files/output" + de[3], data);
                                Console.WriteLine($"File extension: {de[3]}");
                                Console.WriteLine($"Password valid: {de[4]}");
                                Exit();
                            }
                            else
                            {
                                if (headerData != "" && headerData != null)
                                {
                                    string Encryption = "";
                                    if (Hex)
                                    {
                                        Encryption = BitConverter.ToString(GetBinaryFile(filePath));
                                    }
                                    else
                                    {
                                        Encryption = File.ReadAllText(filePath);
                                    }
                                    Encryption = EncryptString(Encryption, signing, headerData, password, extenstion);
                                    File.WriteAllText("files/output.dec", Encryption);
                                    Console.WriteLine($"Encryption of {folderPath} complete.");
                                    Exit();
                                }
                                else
                                {
                                    Console.WriteLine("No Header data found, aborting.");
                                    Exit();
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid file path");
                        Exit();
                    }
                }
            }
            else
            {
                Console.WriteLine("Didn't specify the folder/file path.");
                Exit();
            }

            Exit(null, null);
        }

        ///summary
        ///
        /// Returns an array containing
        /// [0] Header Message
        /// [1] Signing
        /// [2] Message Data
        /// [3] File extension if provided, else null
        /// [4] "1" is password is valid, "0" if not
        ///
        ///summary

        private static string[] DecryptString(string data, string pass = "")
        {
            string[] ret = new string[5];
            ushort passcode = GetPassCodeFromString(pass);
            ushort emptypasscode = GetPassCodeFromString("");

            string[] split = data.Split(robustNewlineDelim, StringSplitOptions.RemoveEmptyEntries);
            if (split.Length < 2) throw new FormatException("Tried to decrypt an invalid valid DEC ENC file, aborting.");
            string[] headersSplit = split[0].Split(HeaderSplitDelimiters, StringSplitOptions.None);
            if (headersSplit.Length < 4) throw new FormatException("Tried to decrypt an invalid valid DEC ENC file, aborting.");

            string headerMsg = Decrypt(headersSplit[1], emptypasscode);
            string sign = Decrypt(headersSplit[2], emptypasscode);
            string check = Decrypt(headersSplit[3], passcode);
            string fileExtension = null;
            if (headersSplit.Length > 4) fileExtension = Decrypt(headersSplit[4], emptypasscode);
            string message;
            string passValid = "true";

            if (check == "ENCODED")
            {
                message = Decrypt(split[1], passcode);
            }
            else
            {
                headerMsg = null;
                sign = null;
                message = null;
                passValid = "false";
            }

            ret[0] = headerMsg;
            ret[1] = sign;
            ret[2] = message;
            ret[3] = fileExtension;
            ret[4] = passValid;
            return ret;
        }

        public static string[] DecryptHeaders(string data, string pass = "")
        {
            string[] strArray = new string[3];
            ushort passCodeFromString = GetPassCodeFromString(pass);
            string[] strArray2 = data.Split(robustNewlineDelim, StringSplitOptions.RemoveEmptyEntries);
            if (strArray2.Length < 2)
            {
                throw new FormatException("Tried to decrypt an invalid valid DEC ENC file, aborting.");
            }
            string[] strArray3 = strArray2[0].Split(HeaderSplitDelimiters, StringSplitOptions.None);
            if (strArray3.Length < 4)
            {
                throw new FormatException("Tried to decrypt an invalid valid DEC ENC file, aborting.");
            }
            string str = Decrypt(strArray3[1], passCodeFromString);
            string str2 = Decrypt(strArray3[2], passCodeFromString);
            string str3 = null;
            if (strArray3.Length > 4)
            {
                str3 = Decrypt(strArray3[4], passCodeFromString);
            }
            strArray[0] = str;
            strArray[1] = str2;
            strArray[2] = str3;
            return strArray;
        }

        private static string Decrypt(string data, ushort passcode)
        {
            StringBuilder builder = new StringBuilder();
            string[] strArray = data.Split(spaceDelim, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < strArray.Length; i++)
            {
                int num2 = Convert.ToInt32(strArray[i]);
                int num3 = 0x7fff;
                int num4 = (num2 - num3) - passcode;
                num4 /= 0x71e;
                builder.Append((char)num4);
            }
            return builder.ToString().Trim();
        }

        //↑↑ Decrypt ↑↑\\
        //=============\\
        //↓↓ Encrypt ↓↓\\

        public static string EncryptString(string data, string Sign, string header = null, string pass = "", string fileExtension = null)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("REMEMBER: THIS IS NOT A REAL, SAFE ENCRYPTION!");
            Console.WriteLine("USE AT YOUR OWN RISK! YOU HAVE BEEN WARNED.\n");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Note: This may take a long time.");

            ushort passCodeFromString = GetPassCodeFromString(pass);
            ushort passcode = GetPassCodeFromString("");
            StringBuilder builder = new StringBuilder();

            string str = "#DEC_ENC::" + Encrypt(header, passcode) + "::" + Encrypt(Sign, passcode) + "::" + Encrypt("ENCODED", passCodeFromString);
            if (fileExtension != null)
            {
                str = str + "::" + Encrypt(fileExtension, passcode);
            }
            builder.Append(str);
            builder.Append("\r\n");
            builder.Append(Encrypt(data, passCodeFromString));
            return builder.ToString();
        }

        private static string Encrypt(string data, ushort passcode)
        {
            StringBuilder ret = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                int newVal = ((ushort)data[i] * 1822) + ushort.MaxValue / 2 + passcode;
                ret.Append(newVal + " ");
            }
            return ret.ToString().Trim();
        }

        // MY RANDOM STUFF \\

        private static byte[] GetBinaryFile(string Path)
        {
            byte[] bytes;
            using (FileStream file = new FileStream(Path, FileMode.Open, FileAccess.Read))
            {
                bytes = new byte[file.Length];
                file.Read(bytes, 0, (int)file.Length);
            }
            return bytes;
        }

        private static string EncryptMix(string String)
        {
            if(String == null)
            {
                throw new ArgumentNullException();
            }

            byte[] plainTextBytes = System.Text.Encoding.UTF8.GetBytes(String);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        private static string DecryptMix(string String)
        {
            if (String == null)
            {
                throw new ArgumentNullException();
            }

            byte[] base64EncodedBytes = System.Convert.FromBase64String(String);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }

        static void Exit(object sender = null, EventArgs e = null)
        {
            Console.ResetColor();
            Environment.Exit(0);
        }
    }
}

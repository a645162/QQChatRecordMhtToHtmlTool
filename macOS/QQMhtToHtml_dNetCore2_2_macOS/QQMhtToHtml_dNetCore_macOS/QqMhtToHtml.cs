﻿using System;
{
    {

        //生成HTML的正文,第二步进行
        public static bool IsGetHtml = false;

        //生成消息附件中的图片,第一步进行
        public static bool IsGetImg = false;

        //保存图片ID和后缀的对应关系
        public static Dictionary<string, string> ImgDictionary = new Dictionary<string, string>();

        //多少条记录换一个新文件继续输出
        public static int FileLength = 50000;

        //进行MHT转HTML的消息记录转化
        public static void DoConvert(string strSrcFilePath)
            bool blEnd = false;             //表示到一个附件结尾的标志位
            bool blDicExist = false;        //表示字典文件是否存在的标志位

            FileStream fsSrc = new FileStream(strSrcFilePath, FileMode.Open);

            //记录每个生成的html文件中的记录条数
            var count = 0;
            //生成多个html文件时的序号
            var fileCount = 1;
                //如果是获取QQ消息文本，则事先加载图片文件字典
                if (File.Exists(OutputPath + "ImgDictionary.txt"))
                    //第2步操作,正文部分读取成HTML文件,5万行记录生成一个文件,并根据字典文件中的后缀信息生成对应URL
                    if (strLine.Contains("<tr><td><div"))
                    //第1步操作,附件部分读取成相应的图片,并将图片名称和后缀信息保存成字典文件
                    if (strLine == "")
                            //保存成图片文件
                            WriteToImage(strImgFileName, strContent, strSuffix);
                            //写入到字典文件,用户读取正文时生成链接
                            swDic.WriteLine(strImgFileName + "," + strSuffix);

        //保存每个图片到对应的文件
        private static void WriteToImage(string strFileName, string strContent, string strSuffix)
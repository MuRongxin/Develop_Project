using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Initinfo : MonoBehaviour {
    
    public static List<string> aloneFirstName=new List<string>();
    public static List<string> twoFirstName=new List<string>();
    public static List<string> middleLastName=new List<string>();
    public static List<string> boyLastName=new List<string>();
    public static List<string> girlLastName=new List<string>();

    public static Dictionary<string,string> firstNameInfoDic=new Dictionary<string, string>();
    private void Awake()
    {
        aloneFirstName.Add("洛");
        aloneFirstName.Add("姬");
        aloneFirstName.Add("蓝");
        aloneFirstName.Add("冷");
        aloneFirstName.Add("梦");
        aloneFirstName.Add("风");
        aloneFirstName.Add("佐");

        twoFirstName.Add("诸葛");
        twoFirstName.Add("独孤");
        twoFirstName.Add("赫连");
        twoFirstName.Add("东方");
        twoFirstName.Add("南宫");
        twoFirstName.Add("上官");

        firstNameInfoDic.Add("南宫","不少古装剧都会给角色赋予南宫这个姓，南宫来源于周朝的姬姓，属于周朝贵族的姓氏。第四个，夏侯，玩过王者荣耀的人都知道夏侯惇，夏侯的姓氏可以追溯到春秋时期，魏国的名将夏侯渊都是一代武将，根据人口统计，拥有这个姓氏的只有1.1万人口了");
        firstNameInfoDic.Add("独孤","独孤姓来自刘姓，汉代刘秀的后代就自称独孤姓，说起独孤，很多人是不是一瞬间就想到了金庸小说里的独孤求败，听名字就知道是以为桀骜不驯的人。");
        firstNameInfoDic.Add("上官","上官这个姓其实就是出自芈姓，是皇亲贵族的姓氏。最后一个，皇甫，皇甫这个姓给人一种皇家的尊贵感，一听姓氏就觉得此人肯定出生不凡。");
        firstNameInfoDic.Add("东方","这个名字虽然有点像方位词，但是用来当做姓氏还是别有风味！");
        firstNameInfoDic.Add("诸葛","诸葛亮神机妙算，鼎鼎大名远近闻名，作为诸葛后人的你是不是感觉非常有脸面了！");
        firstNameInfoDic.Add("赫连","这个姓氏虽然是源自于少数民族，但是写出来是特别好看，文绉绉的，特别招人喜欢。");
        
        firstNameInfoDic.Add("洛","《洛神赋》就是洛开头，以洛为姓，总让人感觉有一股仙气！");
        firstNameInfoDic.Add("姬","这个姓氏来源已久，历史悠远。用姬来作为姓氏，感觉就像是老大哥，特别牛。");
        firstNameInfoDic.Add("蓝","蓝是大海的颜色，用蓝作为姓名，非常少见，但是这样的名字总带有一股悠远的宁静。");
        firstNameInfoDic.Add("冷","冷风凌冽，冷字本带着有温度，用冷作名字，很容易令人想到冷冷酷酷的帅气男生。");
        firstNameInfoDic.Add("梦","这个姓氏基本很难见到，若是以梦为姓氏，作为女子一定是十分具有可爱，梦幻的感觉了。");
        firstNameInfoDic.Add("风","风一般的男子，这种自然类的姓氏来源都比较古老，反而更有一种古朴的味道。");
        firstNameInfoDic.Add("佐","这个姓氏起源于明朝，正是少见，更为别致。");
       
    }

}

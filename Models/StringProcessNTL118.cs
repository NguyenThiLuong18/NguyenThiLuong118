using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NguyenThiLuong118.Models;
using System.Text.RegularExpressions;
namespace NguyenThiLuong118.Models
{
    [Table ("StringProcessNTL118s")]
    public class StringProcessNTL118{
    public string GenerateKey (string input){
        input = input.ToLower();
        input = "" + input;
        foreach(Match m in Regex.Matches(input,@"\s\S"))
        input=input.Replace(m.Value,m.Value.ToUpper());
        return input.Substring(1);
    }
    }
}
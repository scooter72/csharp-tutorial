using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Koans.Training
{
    /// <summary>
    /// Create a function that will return a string that combines all of the letters of the three inputed strings 
    /// in groups. Taking the first letter of all of the inputs and grouping them next to each other. Do this for every letter, 
    /// see example below!
    /// E.g. Input: "aa", "bb" , "cc" => Output: "abcabc"
    /// Note: You can expect all of the inputs to be the same length.
    /// </summary>
    [TestClass]
    public class TripleTrouble
    {
        private static string Merge(string one, string two, string three)
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void SampleTest()
        {
            Assert.AreEqual("ttlheoiscstk", TripleTrouble.Merge("this", "test", "lock"));
            Assert.AreEqual("abcabc", TripleTrouble.Merge("aa", "bb", "cc"));
            Assert.AreEqual("Batman", TripleTrouble.Merge("Bm", "aa", "tn"));
            Assert.AreEqual("LexLuthor", TripleTrouble.Merge("LLh", "euo", "xtr"));
            Assert.AreEqual("ttlheoiscstk", TripleTrouble.Merge("this", "test", "lock"));
            Assert.AreEqual("Batman", TripleTrouble.Merge("Bm", "aa", "tn"));
            Assert.AreEqual("abcabcabc", TripleTrouble.Merge("aaa", "bbb", "ccc"));
            Assert.AreEqual("Supermans", TripleTrouble.Merge("Sea", "urn", "pms"));
            Assert.AreEqual("LexLuthor", TripleTrouble.Merge("LLh", "euo", "xtr"));
            Assert.AreEqual("abcabcabcabcabcabc", TripleTrouble.Merge("aaaaaa", "bbbbbb", "cccccc"));
            Assert.AreEqual("abcabc", TripleTrouble.Merge("aa", "bb", "cc"));
            Assert.AreEqual("brrueordlnsl", TripleTrouble.Merge("burn", "reds", "roll"));

        }


        [TestMethod]
        public void TestRandom()
        {
            Assert.AreEqual("fbwzqm5bt7XuSx7hMq9Ea7BYsKYF4RfRF4pLbmfbJBPJpegOMIDC7nMhZ", TripleTrouble.Merge("fz57Sh97sFf4bbPeMCM", "bqbXxMEBK4RpmJJgI7h", "wmtu7qaYYRFLfBpODnZ"));
            Assert.AreEqual("HfN0hcbGoXIwFkLi5Zs2sOnK2vNdTbsHvDf9", TripleTrouble.Merge("H0bXFisO2dsD", "fhGIk52nvTHf", "NcowLZsKNbv9"));
            Assert.AreEqual("SewrjzIGaDd0Yswzhp21D", TripleTrouble.Merge("SrIDYz2", "ejGdsh1", "wza0wpD"));
            Assert.AreEqual("wP8xMpAACFMVm55LJYeDcsum4t5ROYmHJVrhswmdGZAXoDG13VfeWAfEeV2dusvndEMQNYcXwB7CrW81mDX2", TripleTrouble.Merge("wxAFmLes4RmVsdAD3efVunMYwC8D", "PMAM5JDutOHrwGXGVWE2sdQcBr1X", "8pCV5Ycm5YJhmZo1fAedvENX7Wm2"));
            Assert.AreEqual("IuIznCX3JtXnX4j0zof3IsVDcWIXB0qV3uVUDajWFdmSkZTbYAxZ29uZZFXQ392SCBunjPxYEJypFC", TripleTrouble.Merge("IzXtX0fscXquDWmZYZuF3SuPEp", "un3X4z3VWBVVaFSTA2ZX9CnxJF", "ICJnjoIDI03Ujdkbx9ZQ2BjYyC"));
            Assert.AreEqual("DDr9ADRd4A557DScFkUPioq1JMYUsKEUWmTNMA1Pvi", TripleTrouble.Merge("D9RA7cUoJUEmMP", "DAd5DFPqMsUTAv", "rD45Ski1YKWN1i"));
            Assert.AreEqual("moTzUvqsEvw5ZWzzyo6ut5kjVuFPFtEe9yDMzWDjBcAjjr41WKDkzyHrEuekqbmUqS5lSn9blXs", TripleTrouble.Merge("mzqvZz65VPEyzjArWkHuqU5nl", "oUswWyukuFeDWBj4Kzrebql9X", "TvE5zotjFt9MDcj1DyEkmSSbs"));
            Assert.AreEqual("5B9nzN25qeoKqWIF2c2kzp3R", TripleTrouble.Merge("5n2eqF2p", "Bz5oW2k3", "9NqKIczR"));
            Assert.AreEqual("TitKm9cG0vDu0uciroLnv45e4jIeHaQHs2goJvEfMDzlEUBsZCIArn9YnPQC078af5C8O", TripleTrouble.Merge("TKcv0iL44eQ2JfzUZA9P0aC", "imGDurn5jHHgvMlBCrYQ7f8", "t90ucoveIasoEDEsInnC85O"));
            Assert.AreEqual("Y6kqbrEUZjiaEERPaE2HB3fBoOFZFJRCelnMZAMSUSzqea24IPf8FGwfbjBMmpOQRf6dbE0Z", TripleTrouble.Merge("YqEjEP23oZRlZSzaI8wjmQ6E", "6bUiEaHfOFCnAUq2PFfBpRd0", "krZaREBBFJeMMSe4fGbMOfbZ"));
            Assert.AreEqual("kxtEygNWKQzoT6XzIv099poDjY9eZdDZFFfSCamDyzbYZl8iinSTAa24Ipfaht6rMaiObFxsJwLJNP", TripleTrouble.Merge("kENQTz0pjeDFCDbliT2phriFJJ", "xyWz6I9oYZZfayY8nA4ftMOxwN", "tgKoXv9D9dFSmzZiSaIa6absLP"));
            Assert.AreEqual("7aa5wKuZpMkJX5MgE3uM9CtHd0kJNPsq2Bh9GxKgbA3B05Zw7QGQdDp4q", TripleTrouble.Merge("75uMXguCdJsBGg357Qp", "awZk5EMt0NqhxbBZQd4", "aKpJM39HkP29KA0wGDq"));
            Assert.AreEqual("c6kkMZe4RVXMZRsNu8JsRiaxM6I", TripleTrouble.Merge("ckeVZNJiM", "6M4XRusa6", "kZRMs8RxI"));
            Assert.AreEqual("MzVnTxUO60xdh6oEZu1ziQTqv8B4gxYQRCrcAu3", TripleTrouble.Merge("MnU0hE1Qv4YCA", "zTOx6ZzT8gQru", "Vx6douiqBxRc3"));
            Assert.AreEqual("6eR3LpKV4WXcET36fp2UvasIchMeOMEp0P3D9afFxqAKa5L7Iv6U1j", TripleTrouble.Merge("63KWE62aceEP9FA5IU", "eLVXTfUshOp3axKLv1", "Rp4c3pvIMM0Dfqa76j"));
            Assert.AreEqual("fwIandpGrSslzZz6FJwgFaisgVOWdPtxRYXR191mHjS2sUVhTy1KFCuFOa3SOTmci4UbChFFSKZ", TripleTrouble.Merge("fapSz6wagWtY1mSUTKuaOcUhS", "wnGsZFgiVdxX9H2VyFF3TibFK", "IdrlzJFsOPRR1jsh1COSm4CFZ"));
            Assert.AreEqual("HpAM9qCpXisPnSDbGjXx6zTxA4fvtw24mO7iZqShR7EAL", TripleTrouble.Merge("HMCinbXzAv2OZhE", "p9psSGxT4t47qRA", "AqXPDj6xfwmiS7L"));
            Assert.AreEqual("xteo9twli", TripleTrouble.Merge("xow", "t9l", "eti"));
            Assert.AreEqual("WMMELQ6lpxmYUfBZQ0g9vTl5HvR", TripleTrouble.Merge("WE6xUZgTH", "MLlmfQ9lv", "MQpYB0v5R"));
            Assert.AreEqual("xJHBppLMe", TripleTrouble.Merge("xBL", "JpM", "Hpe"));
            Assert.AreEqual("WABdUXbYZ8mkd6EjgDkQ7", TripleTrouble.Merge("Wdb8djk", "AUYm6gQ", "BXZkED7"));
            Assert.AreEqual("91ygqksoTy4Bdg7S8OdsWScMqK7GJHmNQ7BK", TripleTrouble.Merge("9gsydSdSqGm7", "1qo4g8scKJNB", "ykTB7OWM7HQK"));
            Assert.AreEqual("xr1qvoypbdilOFWxPCqZl0fnmfLMqvgfxnKgmBlonhOrYe4CPaA4UvD7M", TripleTrouble.Merge("xqydOxq0mMgnmoOeP4D", "rvpiFPZffqfKBnr4aU7", "1oblWClnLvxglhYCAvM"));
            Assert.AreEqual("DPcl8p6Dxl40KNbCvElxP", TripleTrouble.Merge("Dl6lKCl", "P8D4Nvx", "cpx0bEP"));
            Assert.AreEqual("kJ7QumKCkNTZ", TripleTrouble.Merge("kQKN", "JuCT", "7mkZ"));
            Assert.AreEqual("VLBijvVqTIYQwcS98VZ86pTos4U3vAqguPG0tfCC3aRAiA7J1Cl14bBq1X0oac5Sb2fhWcQdTWEfYTGs6KBsZzl", TripleTrouble.Merge("ViVIw9Zps3qPtCRA11BXaSfcTfGKZ", "LjqYc88T4vgGf3A7C4q0cbhQWYsBz", "BvTQSV6oUAu0CaiJlb1o52WdET6sl"));
            Assert.AreEqual("NZ9WoXlbf8iqeaxZwHihWgSiQIsQaM", TripleTrouble.Merge("NWl8eZigQQ", "ZobiawhSIa", "9XfqxHWisM"));
            Assert.AreEqual("mQLT6c4z5vnAauaNgWm6RQD6rHaFfpVBSE6ZSG061Rnwtg2x05L3yPmVMPmyByUPamrVyA4ZgqE9nRNKP", TripleTrouble.Merge("mT4vaNmQrFVES6ng03mPBPrAg9N", "Q6znug6DHfB6G1w25yVmyaV4qnK", "Lc5AaWR6apSZ0RtxLPMyUmyZERP"));
            Assert.AreEqual("PkdbMCckNDeC4D7XWHzg9zAwXHLms5CbjYitv8Zo3Nx15evBCQ5FVtnaj", TripleTrouble.Merge("PbcD4XzzXmCYvoxeCFn", "kMkeDWgAHsbi831vQVa", "dCNC7H9wL5jtZN5B5tj"));
            Assert.AreEqual("EF102RBCcfeNlXsKnwBJ13WJkcA6GzuIKE4UwDUfz2BPhyohWKG1YazLsrPaRF6", TripleTrouble.Merge("E0BflKB3k6uEwfByW1zrR", "F2CeXnJWcGI4DzPoKYLPF", "1RcNsw1JAzKUU2hhGasa6"));
            Assert.AreEqual("uVDhdYXjbfT81Gmvxcj5t3ttOtlEx4Ou6YeLuGE8xga3G1TlFdmyfB31m", TripleTrouble.Merge("uhXf1vj3OEOYu8a1Fy3", "VdjTGx5ttxueGx3Tdf1", "DYb8mcttl46LEgGlmBm"));
            Assert.AreEqual("TtxSwgRjCdlbBrYlINc0mXa99TRZP5", TripleTrouble.Merge("TSRdBlcX9Z", "twjlrI0aTP", "xgCbYNm9R5"));
            Assert.AreEqual("niaxULet3mhzz9nc5a32pYwq5TxTcP1TG882k3DaodjNF", TripleTrouble.Merge("nxemzc3Y5T18kaj", "iUth952wTcT83oN", "aL3znapqxPG2DdF"));
            Assert.AreEqual("k9V1W9VCzOwu1AXKRovNs1Bv2BXdOLzilXtx7l228DItF0BCCdM", TripleTrouble.Merge("k1VO1Kv12dzX72I0C", "9WCwARNBBOitl8tBd", "V9zuXosvXLlx2DFCM"));
            Assert.AreEqual("c1zs8k8Um2xnZOIeRkNpv2PotSpC9Ubv94FuhAzXmhQFQeT1rhubQgIjlL9q46VRbCofIY6RvzDOmKYO8", TripleTrouble.Merge("cs82ZeN2tCb4hXQerbIL4RoYvOY", "18UxORpPS9vFAmFThQj96bf6zmO", "zkmnIkvopU9uzhQ1uglqVCIRDK8"));
            Assert.AreEqual("Ucj9fdvfJWBJcqM8oNzytTkdqad47bwurGl3rbhLtmOkQmWXBnfLZJEB1FSEA0irkQbWETQM", TripleTrouble.Merge("U9vWc8zTq4wGrLOmBLEFArbT", "cffBqoyka7ulbtkWnZBS0kWQ", "jdJJMNtddbr3hmQXfJ1EiQEM"));
            Assert.AreEqual("oFHEANEDF3T6lViCkBlJcL2Dh99KATsWSeuE7602OA47Ov853UdRoDNdMDhA", TripleTrouble.Merge("oEE3lClLhKse724v3RND", "FADTVkJ29AWu6O78Uodh", "HNF6iBcD9TSE0AO5dDMA"));
            Assert.AreEqual("3CwK7nGldEnLt5bQ5zvBE", TripleTrouble.Merge("3KGEtQv", "C7ln55B", "wndLbzE"));
            Assert.AreEqual("qzbrPRQ13ZzoU8HxRI2UZPzF5Iv", TripleTrouble.Merge("qrQZUx2P5", "zP1z8RUzI", "bR3oHIZFv"));
            Assert.AreEqual("RNw9JmW7sPYyUmKOVF", TripleTrouble.Merge("R9WPUO", "NJ7YmV", "wmsyKF"));
            Assert.AreEqual("dJHinJu1b9VwGgEkqn0erlKEBtDAxElt0hRDJoJ0Zu47WcRSPBelfk", TripleTrouble.Merge("diu9Gk0lBAlhJ04cPl", "Jn1VgqeKtxtRoZ7RBf", "HJbwEnrEDE0DJuWSek"));
            Assert.AreEqual("28Dh3FuDXYm6jOBaBeAF6qNricuuvjAOPoZEGHPuprhjugsEOldGff5LvV8bV9SxXXr4y6U3OPZPJn", TripleTrouble.Merge("2huYjaAqiuAoGuhgOG5VVxr6OP", "83DmOBFNcvOZHpjslfL89X4UPJ", "DFX6Be6rujPEPruEdfvbSXy3Zn"));
            Assert.AreEqual("CtqfKG3ttsOTuJyZpYtLXzyPSRj2PFqBHY6rodHren7LkmjtZ0u0ZbjM5bN3gBeoCMLWNHuLRCrt2mpqrzcY", TripleTrouble.Merge("Cf3suZtzS2qYor7mZ0jbgoLHRtpz", "tKtOJpLyRPB6deLj0ZMNBCWuC2qc", "qGtTyYXPjFHrHnktub53eMNLrmrY"));
            Assert.AreEqual("zlqztwNQNKdJTIXaNgSGijWtzUSvhLriG", TripleTrouble.Merge("zzNKTaSjzvr", "ltQdINGWUhi", "qwNJXgitSLG"));
            Assert.AreEqual("NkfhdUg5D2OkjeRPeTKRwPP69Ze", TripleTrouble.Merge("Nhg2jPKP9", "kd5OeeRPZ", "fUDkRTw6e"));
            Assert.AreEqual("tCc4CA5w4qC7jngdfPvydRrXXyf8VjhE0EMBZTiiif", TripleTrouble.Merge("t45qjdvRX8hEZi", "CCwCnfyryVEMTi", "cA47gPdXfj0Bif"));
            Assert.AreEqual("yQMsJtvbuoq8bVEgOe7aVI8HeaeELq", TripleTrouble.Merge("ysvobg7IeE", "QJbqVOa8aL", "Mtu8EeVHeq"));
            Assert.AreEqual("P872HLGWOkIxaKGupU", TripleTrouble.Merge("P2Gkau", "8HWIKp", "7LOxGU"));
            Assert.AreEqual("UElF8qRFNsOrPDba9ec7VHIs0NUi7XqytYWHn38MzG3nA32u8tHQNXbM63PvVtIzCZ80q", TripleTrouble.Merge("UFRsPacH0iqYnM338Qb3Vz8", "E8FOD97IN7yW3zn2tNMPtC0", "lqNrbeVsUXtH8GAuHX6vIZq"));
            Assert.AreEqual("xGfQHPOes6UkjNQZlV7KLuoN1G8Dkk", TripleTrouble.Merge("xQO6jZ7u1D", "GHeUNlKoGk", "fPskQVLN8k"));
            Assert.AreEqual("BDo6Av6PL8bKSauJ4inxm3gHCcSZBRK4IBTg4QQnoGvMukVwG6De6wSIhg4hdhN4xgCRHNOnSAJgHTXcH", TripleTrouble.Merge("B668SJn3CZKB4nvkGeSgd4CNSgX", "DAPba4xgcB4TQoMV66I4hxROAHc", "ovLKuimHSRIgQGuwDwhhNgHnJTH"));
            Assert.AreEqual("SFOp7VsK9YWsKH21YOhEp2rZM6nwBNJba7OIqHiqi7O0R", TripleTrouble.Merge("SpsYK1h2MwJ7qqO", "F7KWHYEr6BbOHi0", "OV9s2OpZnNaIi7R"));
            Assert.AreEqual("zBoP5J4C0aYydAs6IvO5RN2uLQp1gso0ImHlIwSAhYHyt1oh8my", TripleTrouble.Merge("zP4ad6ONL1omIAH18", "B5CYAI52Qg0Hwhyom", "oJ0ysvRupsIlSYthy"));
            Assert.AreEqual("mWSmI3DoeDgIvhq03GxWcOX3GEAUmH233LOwUfdOso", TripleTrouble.Merge("mmDDv0xOGU2LUO", "WIogh3WXEm3Ofs", "S3eIqGc3AH3wdo"));
            Assert.AreEqual("d28CMKyo2ycAY8YfE3tCWKmOjT4fYnjoyr3BHBxJxcAFbLzx", TripleTrouble.Merge("dCyyYftKjfjrHJAL", "2Moc8ECmTYo3BxFz", "8K2AY3WO4nyBxcbx"));
            Assert.AreEqual("9YU8mJTPud2QTQPPyMqEXYCFjO4KgxYdGjYOOpLikvXi53eMv0n8JtilVOZYOJs7EYJt1AAIAHdmBeKptrZq", TripleTrouble.Merge("98TdTPqYjKYjOiX3v8iOO7JAAmKr", "YmP2QyECOgdYpkie0JlZJEtAHBpZ", "UJuQPMXF4xGOLv5MntVYsY1Idetq"));
            Assert.AreEqual("ZUWAx2APxTbCadh", TripleTrouble.Merge("ZAATa", "UxPbd", "W2xCh"));
            Assert.AreEqual("uUu0e7CP6k1EtogtCxoEwtEIA3NxCjlAm58Xo0pbSHDMB5gIwr9mzd7BPmzluONX90", TripleTrouble.Merge("u0CkttotAxl5obD5wm7muX", "UeP1oCEE3CA80SMgrzBzO9", "u76EgxwINjmXpHBI9dPlN0"));
            Assert.AreEqual("xpJFMHMvpp1HEWEAUj8LJ86HCADrD3qNKdsdnmx", TripleTrouble.Merge("xFMpEA88Crqdn", "pMv1WUL6ADNsm", "JHpHEjJHD3Kdx"));
            Assert.AreEqual("mrSWXfvOqN2xBpRzsBCLEfsv8o6knlXsvdjcqkthPzBzB", TripleTrouble.Merge("mWvNBzCf8kXdqhB", "rXO2psLsonsjkPz", "SfqxRBEv6lvctzB"));
            Assert.AreEqual("MfM3uljmaG9gYtiKkF0KBhFzIISf6Oe2uFbaYt0wIJCcdKMA8EO5901oZWvmTDpLmGvSRHv1OEB2fn", TripleTrouble.Merge("M3jGYK0hIfeFYwCK851WTLvHO2", "fum9tkKFI62btIcME9ovDmSvEf", "MlagiFBzSOua0JdAO0ZmpGR1Bn"));
            Assert.AreEqual("86Rh1Ai23NwBB8OcFd00WY3s0TXr5z8Jw", TripleTrouble.Merge("8hiNBc0Y0r8", "612w8F03T5J", "RA3BOdWsXzw"));
            Assert.AreEqual("wpB", TripleTrouble.Merge("w", "p", "B"));
            Assert.AreEqual("yLDO2EfGt29l6Yox9kCjqin06EPnPBMibippwHgyNujfrU2k", TripleTrouble.Merge("yOf26xCi6nMiwyjU", "L2G9Y9jnEPipHNf2", "DEtlokq0PBbpgurk"));
            Assert.AreEqual("9BLnbzPhMRxz11spbKXt9A1ENW68IJmLoHP9A59sZHk0s", TripleTrouble.Merge("9nPR1pXAN8mHAsk", "Bbhx1bt1WILP5Z0", "LzMzsK9E6Jo99Hs"));
            Assert.AreEqual("V20zQJf1g8JHZF3RZDolLulspgLoT1aBVPADIS3dqxlQ02f3zIrgLGxlRHKu80hoiHwKEzIHKL5XIU2wARzLK30", TripleTrouble.Merge("Vzf8ZRoupoaPIdl2zgxH8owzKX2RK", "2Q1JFZllgTBASqQfILlK0iKILIwz3", "0JgH3DLsL1VD3x03rGRuhHEH5UAL0"));
            Assert.AreEqual("bZvAIIe0Q7stGVy99kW9L", TripleTrouble.Merge("bAe7G9W", "ZI0sV99", "vIQtykL"));
            Assert.AreEqual("c7PYtqAWeoQhtoDH8BqEHLmJpoczLjh0DA7yvuY", TripleTrouble.Merge("cYAotHqLpzhAv", "7tWQo8EmoL07u", "PqehDBHJcjDyY"));
            Assert.AreEqual("z3cDcjmJ52lUSGSRVGsFNKK4HaesrPWOm2ONsiqGCT4T7Mi6spdpBTkoti5CF3bqfXsZ1Fiw", TripleTrouble.Merge("zDm2SRsKHsW2sG4MspkiFqsF", "3cJlGVFKarOOiCTipBo53fZi", "cj5USGN4ePmNqT76dTtCbX1w"));
            Assert.AreEqual("mC4Q1651hABvrMTSjeKmoAI1NxjdIEmGrPZR", TripleTrouble.Merge("mQ5ArSKANdmP", "C11BMjmIxIGZ", "46hvTeo1jErR"));
            Assert.AreEqual("Y1l9Kh3a5yLZGRkYJul3DDDWbtdX4DbxBnLnimedPbR9YEBwCshexXmUxOia", TripleTrouble.Merge("Y93yGYlDbXbnidRECemO", "1KaLRJ3Dt4xLmP9BsxUi", "lh5ZkuDWdDBnebYwhXxa"));
            Assert.AreEqual("gf1WXXdG7", TripleTrouble.Merge("gWd", "fXG", "1X7"));
            Assert.AreEqual("gQIolvE8WsqUMg6AoB1zUEDYs6amBriqE1BNosAitQLsXLSVaXtcOIgbNt5pVc6pKAPVfsV5BSG", TripleTrouble.Merge("goEsMA1Esmi1oiLLacgtVpPsB", "Ql8qgozD6BqBstsSXOb5cKVVS", "IvWU6BUYarENAQXVtINp6Af5G"));
            Assert.AreEqual("3VBhoF", TripleTrouble.Merge("3h", "Vo", "BF"));
            Assert.AreEqual("n8Fb6VjA4xUNQTfiX5", TripleTrouble.Merge("nbjxQi", "86AUTX", "FV4Nf5"));
            Assert.AreEqual("zrBxb6Bci2sYBQQSrEiT96sbIqFzuXwnlrPfmKoe43AILYS6AAyeym738kpu1MrLFExUBvqgZDYG5jPuXIzu", TripleTrouble.Merge("zxB2BSi6IzwrmeAYAe7k1LxvZGPI", "rbcsQrTsqunPK4ISAy3pMFUqD5uz", "B6iYQE9bFXlfo3L6ym8urEBgYjXu"));
            Assert.AreEqual("Sz8uVgBf4nsMyDGk85OTREuO17ZU5WtW7mwPykqPoBfap4HgIJZ", TripleTrouble.Merge("SuBnykOE1UtmyPf4I", "zVfsD8Tu75WwkoaHJ", "8g4MG5ROZW7PqBpgZ"));
            Assert.AreEqual("kaROEu2XGqjh3VOLQ1", TripleTrouble.Merge("kO2q3L", "aEXjVQ", "RuGhO1"));
            Assert.AreEqual("YP9oPiUi702Mv7gvhViLErSI7b8gTp5QRXA7lvBpuL5hNeyjXkrzrprr60qxkxOR4m4Y6", TripleTrouble.Merge("YoU0vvir7g5Xlp5eXzr0kR4", "PPi27hLSbTQAvuhykrrqx4Y", "9i7MgVEI8pR7BLNjrp6xOm6"));
            Assert.AreEqual("KvU3a2vv4dnYJt8FilqTAuENE67omlkZnxZ5fyOy5L6NKMneTyE", TripleTrouble.Merge("K3vdJFquEokxfy6MT", "vavntiTE6mZZy5Nny", "U24Y8lAN7ln5OLKeE"));
            Assert.AreEqual("smjarHye5HJT3OuVTDkuX1Yyy1D", TripleTrouble.Merge("sayH3Vk1y", "mreJOTuY1", "jH5TuDXyD"));
            Assert.AreEqual("ScVxhRrAO9OY9u2yCmU6bSKQOU50OumzD6LdwVwlguGUyMum8jwLgHaAREjMV0veXYUDjYCqztZrL0", TripleTrouble.Merge("Sxr99yUSO0m6wlGM8LaEVeUYzr", "chAOuC6KUOzLVgUujgAj0XDCtL", "VROY2mbQ5uDdwuymwHRMvYjqZ0"));
            Assert.AreEqual("BjT1o7aT6fKMrwjPq8m6a2qCkhFVxrtzanhnC8H", TripleTrouble.Merge("B1afrPm2kVtnC", "joTKwq6qhxzh8", "T76Mj8aCFranH"));
            Assert.AreEqual("7EXhZMU3Qdtsi3AJ3RRG1EfPwUwDP6Nr1F9VfJmXMLFU8AQg", TripleTrouble.Merge("7hUdiJREwDNFfXFA", "EZ3t33GfUPr9JMUQ", "XMQsAR1Pw61VmL8g"));
            Assert.AreEqual("XtvrAo2jHuEaRoTQC1d4pouo34p8LRvEPb1MbA1aHwXYi75hwD5Jxm7t9", TripleTrouble.Merge("Xr2uRQdo38vbbaX7wJ7", "tAjEoC4u4LE1AHY5Dxt", "voHaT1popRPM1wih5m9"));
            Assert.AreEqual("xF93X09AK0wG", TripleTrouble.Merge("x390", "FXAw", "90KG"));
            Assert.AreEqual("C9Cx3RWF58IMHVlQneINUMvbNZgYhxFupP3KvyEbnB1H0qPeXtgWo3dzOkjdu7hI3Xh1bbfy", TripleTrouble.Merge("CxW8HQIMNYFPvb1qXWdkuIhb", "93FIVnNvZhu3ynHPtozj731f", "CR5MleUbgxpKEB0eg3OdhXby"));
            Assert.AreEqual("qjTVnkgJBByQtGvwE5KOkrqdsOcJXD5Os67TJek", TripleTrouble.Merge("qVgBtwKrsJ56J", "jnJyGEOqOXO7e", "TkBQv5kdcDsTk"));
            Assert.AreEqual("DTs5t1JRvFXfVjz930mZIXw8FjixIcmkVKLQ9ut1ELXRpZ2IG8aT1K1pht0JTWITcwKKYjAJGvV79eSpqaqKBSs", TripleTrouble.Merge("D5JFV9mXFxmK91XZGT1tTTKjG7SaB", "TtRXj3ZwjIkLuER281p0WcKAv9pqS", "s1vfz0I8icVQtLpIaKhJIwYJVeqKs"));
            Assert.AreEqual("SftP3jhrCEz3Psu", TripleTrouble.Merge("SPhEP", "f3rzs", "tjC3u"));
            Assert.AreEqual("8QNGz4qCaKd3p8RKEA220uPgNn55pZa8qJMvFmUYzqytGoCD", TripleTrouble.Merge("8GqKpK2uN5aJFYyo", "QzCd8E2Pnp8MmztC", "N4a3RA0g5ZqvUqGD"));
            Assert.AreEqual("pzO01qNBq2M9uXAueNfwgEbqdCJ5gajk1IAkMIyd8tZtIYETy8magRPkXiWygSePTlHlW", TripleTrouble.Merge("p0N2uufEd5jIMdZYyaPigPH", "z1BMXewbCgkAI8tE8gkWSTl", "Oqq9ANgqJa1kytITmRXyelW"));
            Assert.AreEqual("hVYCxwpshE80HhyIEk2aNnw96pPJagQc6XaQCed", TripleTrouble.Merge("hCpEHI2n6JQXC", "Vxs8hEawpacae", "Ywh0ykN9Pg6Qd"));
            Assert.AreEqual("4pAR0qK6bLhht6N4jYGIhgSBxf4tGhGkGZfhneJQfS", TripleTrouble.Merge("4RKLt4GgxtGZnQ", "p06h6jISfGkfef", "AqbhNYhB4hGhJS"));
            Assert.AreEqual("O9tt9KgrnXV5YX9eVvb04F6bTbpQEP0mPzDBEv5jkzcMveHKoAyeDbwJCRahfPn", TripleTrouble.Merge("OtgXYebFTQ0zEjceoewRf", "99rVXV06bEmDvkMHADJaP", "tKn59v4bpPPB5zvKybChn"));
            Assert.AreEqual("hspiU7Zjz2QFmupzUemDbVjxD39wVXDULFpD", TripleTrouble.Merge("hiZ2mzmVDwDF", "sUjQuUDj3VUp", "p7zFpebx9XLD"));
            Assert.AreEqual("i0qlPpLLqhSmlNBmj6MJ2fa8mOcy53hFmAvn5cLqXlWVqKtKCrmId35DZs8AMWQwAN9kcXrG", TripleTrouble.Merge("ilLhlmMfmyhA5qWKCI5sMw9X", "0PLSNjJaO5FvcXVtrdD8WAkr", "qpqmB628c3mnLlqKm3ZAQNcG"));
            Assert.AreEqual("fvQIFRceRwORYmsErNNeLdAVkUcLJroAfX7Ip5Uagg4kBemlQfuJdmjCv4iuyQVkIO", TripleTrouble.Merge("fIcwYENdkLoXpa4eQJj4yk", "vFeOmreAUJA75gkmfdCiQI", "QRRRsNLVcrfIUgBlumvuVO"));
            Assert.AreEqual("BokZw3w8oiaTFs14n6eg3x4WuWklPLUbxtk6pG8Qro5eVldB7Vrnnr2NuOpZSKsdN8gWH", TripleTrouble.Merge("BZwiF4exulUtpQ5l7n2OSdg", "ow8asng4WPbkGredVnNpKNW", "k3oT163WkLx68oVBrruZs8H"));
            Assert.AreEqual("Ph8NzP2aBJ3io3dryG0XMbbi8g5bQWEH3CGKoa2nVUMfgugy9gKafusyGaPSTaJoEwplxSCXNNC2O5COA", TripleTrouble.Merge("PN2Jor0b8bEConMu9asaTopSN2C", "hza33yXbgQHGaVfggfyPaElCNOO", "8PBidGMi5W3K2UgyKuGSJwxXC5A"));
        }

    }
}

using SeleniumMSFlow.Helpers.Models;
using System.Collections.Generic;

namespace SeleniumMSFlow.Helpers
{
    public class ProvidersInfo
    {
        private static readonly GameProviderInfo Igrosoft = new()
        {
            Name = "IGROSOFT",
            UrlPart = "IgroSoft",
            ProviderUrl = ".math-server.net/",
            GameValidator = "//*[@class='app']"
        };
        private static readonly GameProviderInfo EGT = new()
        {
            Name = "EGT",
            UrlPart = "EGT",
            ProviderUrl = "https://s4.egtmgs.com",
            GameValidator = "//*[@id='gpts']"        //*[@id='footer']         //inside second iframe
        };
        private static readonly GameProviderInfo Amatic = new()
        {
            Name = "AMATIC",
            UrlPart = "Amatic",
            ProviderUrl = "cdn.amatic.com/gmsl/",
            GameValidator = "//*[@id='gameArea']"
        };
        private static readonly GameProviderInfo Cayetano = new()
        {
            Name = "CAYETANO",
            UrlPart = "Cayetano",
            ProviderUrl = "https://gserver-adjarabet.redtiger.cash/adjarabet/launcher/",
            GameValidator = "//*[@id='gameCanvas']"
        };
        private static readonly GameProviderInfo PlayNGo = new()
        {
            Name = "PLAY\'N GO",
            UrlPart = "PlayNGo",
            ProviderUrl = "https://sisgames.adjarabet.com/game-playngo/static/game_launcher.php",
            GameValidator = "//div[@id='pngCasinoGame']//iframe[contains(@src,'playngonetwork.com')]"
        };
        private static readonly GameProviderInfo PlayNGoMobile = new()
        {
            Name = PlayNGo.Name,
            UrlPart = PlayNGo.UrlPart,
            ProviderUrl = "https://aeucw.playngonetwork.com/casino/PlayMobile?pid=",
            GameValidator = "//*[@id='gameWrapper']"
        };
        private static readonly GameProviderInfo PlayNGoAM = new()
        {
            Name = PlayNGo.Name,
            UrlPart = PlayNGo.UrlPart,
            ProviderUrl = "https://sisgames.adjarabet.am/game-playngo/static",
            GameValidator = PlayNGo.GameValidator
        };
        private static readonly GameProviderInfo PlayNGoAMMobile = new()
        {
            Name = PlayNGo.Name,
            UrlPart = PlayNGo.UrlPart,
            ProviderUrl = "https://cw.playngonetwork.com/casino/PlayMobile?pid=",
            GameValidator = PlayNGoMobile.GameValidator
        };
        private static readonly GameProviderInfo RedTiger = new()
        {
            Name = "RED TIGER",
            UrlPart = "RedTiger",
            ProviderUrl = "https://gserver-adjarabet.redtiger.cash/adjarabet/launcher/",
            GameValidator = "//div[contains(@class,'bars')]"
        };
        private static readonly GameProviderInfo Novomatic = new()
        {
            Name = "NOVOMATIC",
            UrlPart = "Novomatic",
            ProviderUrl = "https://nrgs-b2b.greentube.com/Nrgs/B2B/Web/Adjarabet",
            GameValidator = "//div[@id='game']/canvas"
        };
        private static readonly GameProviderInfo Yggdrasil = new()
        {
            Name = "YGGDRASIL",
            UrlPart = "Yggdrasil",
            ProviderUrl = "https://static-cw.prod-ygg.com/init/launchClient.html?gameid=",
            GameValidator = "//div[@id='pc-root']"
        };
        private static readonly GameProviderInfo YggdrasilMobile = new()
        {
            Name = Yggdrasil.Name,
            UrlPart = Yggdrasil.UrlPart,
            ProviderUrl = "https://static-cw.prod-ygg.com",
            GameValidator = Yggdrasil.GameValidator
        };
        private static readonly GameProviderInfo Netent = new()
        {
            Name = "NETENT",
            UrlPart = "NETENT",
            ProviderUrl = "https://gamelaunch.everymatrix.com/Loader/Start/",
            GameValidator = "//*[@id='ifmGame']"
        };
        private static readonly GameProviderInfo BFGames = new()
        {
            Name = "BF GAMES",
            UrlPart = "BFGames",
            ProviderUrl = "https://gamelaunch.everymatrix.com/Loader/Start/",
            GameValidator = "//*[@id='gameContainer']"
        };
        private static readonly GameProviderInfo Blueprint = new()
        {
            Name = "BLUEPRINT",
            UrlPart = "Blueprint",
            ProviderUrl = "https://gamelaunch.everymatrix.com/Loader/Start/",
            GameValidator = "//*[@id='ifmGame']"
        };
        private static readonly GameProviderInfo NYX = new()
        {
            Name = "NYX",
            UrlPart = "NYX",
            ProviderUrl = "https://nogs-gl.nyxmalta.com/game",
            GameValidator = "//*[@id='game']"
        };
        private static readonly GameProviderInfo NYXAm = new()
        {
            Name = NYX.Name,
            UrlPart = NYX.UrlPart,
            ProviderUrl = NYX.ProviderUrl,
            GameValidator = "//*[@id='game']"

        };
        private static readonly GameProviderInfo NYXMobile = new()
        {
            Name = NYX.Name,
            UrlPart = NYX.UrlPart,
            ProviderUrl = "https://static.contentmedia.eu/",
            GameValidator = "//*[@id='game']"
        };
        private static readonly GameProviderInfo BTG = new()
        {
            Name = "BTG",
            UrlPart = "BTG",
            ProviderUrl = "https://nogs-gl.nyxmalta.com/game",
            GameValidator = "//*[@id='gameIFrame']"
        };
        private static readonly GameProviderInfo BTGMobile = new()
        {
            Name = BTG.Name,
            UrlPart = BTG.UrlPart,
            ProviderUrl = "https://gdm-eu-prod.ext.nyxop.net/",
            GameValidator = "//*[@id='gameiframe']"
        };
        private static readonly GameProviderInfo Nextgen = new()
        {
            Name = "NEXTGEN",
            UrlPart = "NextGen",
            ProviderUrl = "https://nogs-gl.nyxmalta.com/game",
            GameValidator = "//*[@id='gameIFrame']"
        };
        private static readonly GameProviderInfo NextgenMobile = new()
        {
            Name = Nextgen.Name,
            UrlPart = Nextgen.UrlPart,
            ProviderUrl = "https://gdm-eu-prod.ext.nyxop.net/",
            GameValidator = "//*[@id='gameiframe']"
        };
        private static readonly GameProviderInfo Amaya = new()
        {
            Name = "AMAYA",
            UrlPart = "AMAYA",
            ProviderUrl = "https://nogs-gl.nyxmalta.com/game",
            GameValidator = "//div[@id='game']"
        };
        private static readonly GameProviderInfo AmayaMobile = new()
        {
            Name = Amaya.Name,
            UrlPart = Amaya.UrlPart,
            ProviderUrl = "nyxop.net",
            GameValidator = "//*[@id='gameiframe']"
        };
        private static readonly GameProviderInfo PushGaming = new()
        {
            Name = "PUSH GAMING",
            UrlPart = "Pushgaming",
            ProviderUrl = "https://gamelaunch.everymatrix.com/Loader/Start/",
            GameValidator = "//*[@id='ifmGame']"
        };
        private static readonly GameProviderInfo PushGamingAM = new()
        {
            Name = PushGaming.Name,
            UrlPart = PushGaming.UrlPart,
            ProviderUrl = "https://gamelaunch.everymatrix.com/Loader/Start/",
            GameValidator = PushGaming.GameValidator
        };
        private static readonly GameProviderInfo Evoplay = new()
        {
            Name = "EVOPLAY",
            UrlPart = "EvoPlay",
            ProviderUrl = "https://run.evoplay.games/game/fullstate/html5/evoplay/",
            GameValidator = "//*[@id='app-container']//canvas[@id='canvas']"
        };
        private static readonly GameProviderInfo Wazdan = new()
        {
            Name = "WAZDAN",
            UrlPart = "Wazdan",
            ProviderUrl = "https://gamelaunch.everymatrix.com/Loader/Start/",
            GameValidator = "//*[@id='ifmGame']"
        };
        private static readonly GameProviderInfo WazdanMobile = new()
        {
            Name = Wazdan.Name,
            UrlPart = Wazdan.UrlPart,
            ProviderUrl = "wazdan.com/",
            GameValidator = "//*[@id='Default']"
        };
        private static readonly GameProviderInfo Synot = new()
        {
            Name = "SYNOT",
            UrlPart = "Synot",
            ProviderUrl = "https://gamelaunch.everymatrix.com/Loader/Start/",
            GameValidator = "//*[@id='ifmGame']"
        };
        private static readonly GameProviderInfo Pragmatic = new()
        {
            Name = "PRAGMATIC",
            UrlPart = "Pragmatic",
            ProviderUrl = "https://adjarabet-dk1.pragmaticplay.net/gs2c/playGame.do",
            GameValidator = "//*[@id='Desktop']"
        };
        private static readonly GameProviderInfo PragmaticMobile = new()
        {
            Name = Pragmatic.Name,
            UrlPart = Pragmatic.UrlPart,
            ProviderUrl = "https://adjarabet-dk1.pragmaticplay.net",
            GameValidator = "//*[@id='Mobile']"
        };
        private static readonly GameProviderInfo Playson = new()
        {
            Name = "PLAYSON",
            UrlPart = "PLAYSON",
            ProviderUrl = "gamespace.com",
            GameValidator = "//*[@id='game_canvas']"
        };
        private static readonly GameProviderInfo PlaysonMobile = new()
        {
            Name = Playson.Name,
            UrlPart = Playson.UrlPart,
            ProviderUrl = "gamespace.com",
            GameValidator = "//*[@id='game_canvas']"
        };
        private static readonly GameProviderInfo PlaysonAMMobile = new()
        {
            Name = Playson.Name,
            UrlPart = Playson.UrlPart,
            ProviderUrl = "gamespace.com/",
            GameValidator = "//*[@id='game_canvas']"
        };
        private static readonly GameProviderInfo Booming = new()
        {
            Name = "BOOMING",
            UrlPart = "BOOMING",
            ProviderUrl = "https://play.cis.booming-games.com/",
            GameValidator = "//*[@id='wrapper']"
        };
        private static readonly GameProviderInfo Leander = new()
        {
            Name = "LEANDER",
            UrlPart = "Leander",
            ProviderUrl = "https://gamelaunch.everymatrix.com/Loader/Start/",
            GameValidator = "//*[@id='ifmGame']"
        };
        private static readonly GameProviderInfo Microgaming = new()
        {
            Name = "MICROGAMING",
            UrlPart = "MICROGAMING",
            ProviderUrl = "https://redirector3.valueactive.eu/Casino/Default.aspx?applicationid=",
            GameValidator = "//*[@id='splash-screen1']"
        };
        private static readonly GameProviderInfo MicrogamingMobile = new()
        {
            Name = Microgaming.Name,
            UrlPart = Microgaming.UrlPart,
            ProviderUrl = "https://mobile3.gameassists.co.uk",
            GameValidator = Microgaming.GameValidator
        };
        private static readonly GameProviderInfo Spribe = new()
        {
            Name = "SPRIBE",
            UrlPart = "Spribe",
            ProviderUrl = "",
            GameValidator = ""
        };
        private static readonly GameProviderInfo EGTScarabJackpot = new()
        {
            Name = "EGT Scarab Jackpot",
            UrlPart = "EGTScarabJackpot",
            ProviderUrl = EGT.ProviderUrl,
            GameValidator = "//*[@id='sessionClosed']"
        };
        private static readonly GameProviderInfo EGTEgyptQuest = new()
        {
            Name = "EGT EQ",
            UrlPart = "EGTEgyptQuest",
            ProviderUrl = EGT.ProviderUrl,
            GameValidator = "//*[@id='content']"
        };
        private static readonly GameProviderInfo EGTEgyptStone = new()
        {
            Name = "EGT Egypt Stone",
            UrlPart = "EGTEgyptStone",
            ProviderUrl = EGT.ProviderUrl,
            GameValidator = "//*[@id='content']"
        };

    }
}

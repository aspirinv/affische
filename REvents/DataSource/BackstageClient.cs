using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REvents.DataSource
{
    public class BackstageClient
    {
        public async Task<ICollection<BackstageEvent>> GetEvents()
        {
            return await Task.FromResult(new[] {
        new BackstageEvent{
                id = "65ca06b38449e",
        name = "KINGS OF FLOYD - 'Eclipse'-Tour ",
        description = "Pink Floyd-Tribute Band",
        venue = "BACKSTAGE HALLE",
        date = "10/05/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/kings-of-floyd-eclipse-tour.html",
        pkstatus = "62"
    }, new BackstageEvent {
                id = "65ca06b386469",
        name = "SPIDERGAWD - European Tour 2024",
        description = "Hardrock, Heavy Metal",
        venue = "BACKSTAGE HALLE",
        date = "03/10/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/spidergawd-european-tour-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b387a14",
        name = "BUSTER SHUFFLE - Hold Back The Rebels Tour",
        description = "Ska",
        venue = "BACKSTAGE CLUB",
        date = "02/17/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/buster-shuffle-hold-back-the-rebels-tour.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b388c83",
        name = "ACHT EIMER HÜHNERHERZEN - Reise 2024",
        description = "Rock",
        venue = "BACKSTAGE HALLE",
        date = "03/24/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/acht-eimer-huhnerherzen-reise-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b38a61f",
        name = "CATTLE DECAPITATION - Terrasite Over Europe 2024",
        description = "Deathgrind",
        venue = "BACKSTAGE HALLE",
        date = "03/20/2024",
        time = "19:00",
        type = "event",
        url = "https://backstage.eu/cattle-decapitation-terrasite-over-europe-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b38ba1a",
        name = "AMARANTHE & DRAGONFORCE - European Co-Headline Tour 2024",
        description = "Symphonic Metal",
        venue = "TonHalle (Werksviertel-Mitte)",
        date = "03/09/2024",
        time = "18:40",
        type = "event",
        url = "https://backstage.eu/amaranthe-dragonforce-european-co-headline-tour-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b38ce7b",
        name = "ETERNAL CHAMPION - 10th Anniversary Tour",
        description = "Heavy Metal",
        venue = "BACKSTAGE CLUB",
        date = "03/04/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/eternal-champion-10th-anniversary-tour.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b38e1b6",
        name = "SOULY - Ich wünschte, es würd' mich kümmern Tour 2024",
        description = "Rap",
        venue = "BACKSTAGE WERK",
        date = "02/29/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/souly-ich-wunschte-es-wurd-mich-kummern-tour-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b38f331",
        name = "New Model Army \u2013 Unbroken Tour 2024",
        description = "Rock",
        venue = "BACKSTAGE WERK",
        date = "03/05/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/new-model-army-unbroken-tour-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b390ae4",
        name = "NAPALM DEATH - Campaign for Musical Destruction Tour 2024",
        description = "Death Metal",
        venue = "BACKSTAGE WERK",
        date = "02/19/2024",
        time = "19:00",
        type = "event",
        url = "https://backstage.eu/napalm-death-campaign-for-musical-destruction-tour-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b39235a",
        name = "MIDNIGHT - European Tour 2024",
        description = "Metal",
        venue = "BACKSTAGE CLUB",
        date = "04/24/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/midnight-european-tour-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b393a68",
        name = "SARAH LESCH - Gute Nachrichten Tour 2024",
        description = "Liedermacherin",
        venue = "BACKSTAGE CLUB",
        date = "06/10/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/sarah-lesch-gute-nachrichten-tour-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b395431",
        name = "DEAD BY APRIL - The Affliction Tour 2024",
        description = "Metal",
        venue = "BACKSTAGE WERK",
        date = "10/09/2024",
        time = "19:00",
        type = "event",
        url = "https://backstage.eu/dead-by-april-the-affliction-tour-2024.html",
        pkstatus = "62"
         }, new BackstageEvent {
                id = "65ca06b396aa3",
        name = "GIACOMO TURRA AND THE FUNKY MINUTES - UK & Europe Tour",
        description = "Rock",
        venue = "BACKSTAGE CLUB",
        date = "02/13/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/giacomo-turra-and-the-funky-minutes-uk-europe-tour.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b398350",
        name = "FREIBURG vs. FC BAYERN | Bundesliga 23/24",
        description = "Fussball Liveübertragung",
        venue = "REITKNECHT 6",
        date = "03/01/2024",
        time = "20:30",
        type = "event",
        url = "https://backstage.eu/freiburg-vs-fc-bayern-bundesliga-23-24.html",
        pkstatus = "61"
         }, new BackstageEvent {
                id = "65ca06b399dab",
        name = "Rrotzer - DUMME IDEEN TOUR 2024",
        description = "Pop",
        venue = "BACKSTAGE CLUB",
        date = "12/10/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/rrotzer-dumme-ideen-tour-2024.html",
        pkstatus = "62"
         }, new BackstageEvent {
                id = "65ca06b39b36e",
        name = "TARTAN SPECIALS + TED CHRISTOPHER plus djs Tam and Ross",
        description = "Football Party",
        venue = "BACKSTAGE HALLE",
        date = "06/13/2024",
        time = "19:00",
        type = "event",
        url = "https://backstage.eu/tartan-specials-ted-christopher-plus-djs-tam-and-ross.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b39c7ae",
        name = "KENSINGTON ROAD \u2013 CHARLIE IS ALIVE TOUR 2024",
        description = "Alternative, Indie Rock",
        venue = "BACKSTAGE CLUB",
        date = "06/01/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/kensington-road.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b39de6a",
        name = "CAMOUFLAGE - REWIND TO THE FUTURE AND GOODBYE LIVE | verlegt auf den 23.10.24",
        description = "Synth Pop",
        venue = "BACKSTAGE WERK",
        date = "10/23/2024",
        time = "19:00",
        type = "event",
        url = "https://backstage.eu/camouflage-rewind-to-the-future-and-goodbye-live-2023.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b39f843",
        name = "CROSSING FRIDAY",
        description = "Metal, Punk, Hardcore, Alternative ",
        venue = "BACKSTAGE CLUB",
        date = "02/16/2024",
        time = "23:00",
        type = "event",
        url = "https://backstage.eu/crossing-frioday-mit-dj-rock-al.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b3a02d2",
        name = "CROSSING FRIDAY",
        description = "Metal, Punk, Hardcore, Alternative ",
        venue = "BACKSTAGE CLUB",
        date = "02/23/2024",
        time = "23:00",
        type = "event",
        url = "https://backstage.eu/crossing-frioday-mit-dj-rock-al.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b3a0716",
        name = "CROSSING FRIDAY",
        description = "Metal, Punk, Hardcore, Alternative ",
        venue = "BACKSTAGE CLUB",
        date = "03/08/2024",
        time = "23:00",
        type = "event",
        url = "https://backstage.eu/crossing-frioday-mit-dj-rock-al.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b3a0c49",
        name = "CROSSING FRIDAY",
        description = "Metal, Punk, Hardcore, Alternative ",
        venue = "BACKSTAGE CLUB",
        date = "03/15/2024",
        time = "23:00",
        type = "event",
        url = "https://backstage.eu/crossing-frioday-mit-dj-rock-al.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b3a152e",
        name = "CROSSING FRIDAY",
        description = "Metal, Punk, Hardcore, Alternative ",
        venue = "BACKSTAGE CLUB",
        date = "03/22/2024",
        time = "23:00",
        type = "event",
        url = "https://backstage.eu/crossing-frioday-mit-dj-rock-al.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b3a1d56",
        name = "CROSSING FRIDAY",
        description = "Metal, Punk, Hardcore, Alternative ",
        venue = "BACKSTAGE CLUB",
        date = "03/29/2024",
        time = "23:00",
        type = "event",
        url = "https://backstage.eu/crossing-frioday-mit-dj-rock-al.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b3a22fe",
        name = "CROSSING FRIDAY",
        description = "Metal, Punk, Hardcore, Alternative ",
        venue = "BACKSTAGE CLUB",
        date = "04/12/2024",
        time = "23:00",
        type = "event",
        url = "https://backstage.eu/crossing-frioday-mit-dj-rock-al.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b3a2714",
        name = "CROSSING FRIDAY",
        description = "Metal, Punk, Hardcore, Alternative ",
        venue = "BACKSTAGE CLUB",
        date = "04/19/2024",
        time = "23:00",
        type = "event",
        url = "https://backstage.eu/crossing-frioday-mit-dj-rock-al.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b3a2c76",
        name = "CROSSING FRIDAY",
        description = "Metal, Punk, Hardcore, Alternative ",
        venue = "BACKSTAGE CLUB",
        date = "04/26/2024",
        time = "23:00",
        type = "event",
        url = "https://backstage.eu/crossing-frioday-mit-dj-rock-al.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b3a40b2",
        name = "BLAZE BAYLEY - Unstoppable Tour 2023 / 2024 | Neuer Termin: 12.05.24",
        description = "Metal",
        venue = "BACKSTAGE CLUB",
        date = "05/12/2024",
        time = "19:00",
        type = "event",
        url = "https://backstage.eu/blaze-bayley-unstoppable-tour-2023.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b3a5895",
        name = "Kalapi - Heimspiel im Backstage München | verlegt auf den 09.11.24",
        description = "Punk, Rock",
        venue = "BACKSTAGE CLUB",
        date = "11/09/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/kalapi-heimspiel-im-backstage-munchen.html",
        pkstatus = "62"
         }, new BackstageEvent {
                id = "65ca06b3a6a1a",
        name = "SUBSIGNAL + POWERIZED |\u00a0Nachholtermin vom 12.10.23",
        description = "Progressive Rock",
        venue = "BACKSTAGE CLUB",
        date = "03/24/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/subsignal.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b3a859f",
        name = "FLETCHER - Live 2023 | verlegt auf den 24.04.24",
        description = "Selbstbewusster Pop von Fletcher",
        venue = "BACKSTAGE WERK",
        date = "04/24/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/fletcher-live-2023.html",
        pkstatus = "49"
         }, new BackstageEvent {
                id = "65ca06b3aa0cf",
        name = "MONACO F & BAND - Grün ist die Hopfnung Tour 2024 | Nachholtermin vom 02.12.23",
        description = "Bayrischer Rap",
        venue = "BACKSTAGE HALLE",
        date = "03/08/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/monaco-f-band-grun-ist-die-hopfnung-tour-2023.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b3abc91",
        name = "SCHMUTZKI |Schmutz De La Schmutz Tour 2024",
        description = "Stuttgarter Punkrock-/Indie-Rock-Band",
        venue = "BACKSTAGE WERK",
        date = "03/01/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/schmutzki-schmutz-de-la-schmutz-tour-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b3ad456",
        name = "DEINE COUSINE - TOUR 2024",
        description = "Rock",
        venue = "BACKSTAGE WERK",
        date = "04/12/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/deine-cousine-tour-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b3ae6eb",
        name = "EISFABRIK - Tour 2024",
        description = "Electro Pop",
        venue = "BACKSTAGE HALLE",
        date = "02/23/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/eisfabrik-tour-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b3af628",
        name = "MAGIC MEN AUSTRALIA IN MUNICH GERMANY",
        description = "Australia\u2019s BEST MALE DANCE GROUP",
        venue = "BACKSTAGE WERK",
        date = "05/10/2024",
        time = "18:15",
        type = "event",
        url = "https://backstage.eu/magic-men-australia-in-munich-germany-10-05-2024.html",
        pkstatus = "62"
         }, new BackstageEvent {
                id = "65ca06b3afe1e",
        name = "MAGIC MEN AUSTRALIA IN MUNICH GERMANY",
        description = "Australia\u2019s BEST MALE DANCE GROUP",
        venue = "BACKSTAGE WERK",
        date = "05/10/2024",
        time = "22:00",
        type = "event",
        url = "https://backstage.eu/magic-men-australia-in-munich-germany-10-05-2024.html",
        pkstatus = "62"
         }, new BackstageEvent {
                id = "65ca06b3b01e9",
        name = "MAGIC MEN AUSTRALIA IN MUNICH GERMANY",
        description = "Australia\u2019s BEST MALE DANCE GROUP",
        venue = "BACKSTAGE WERK",
        date = "05/11/2024",
        time = "18:15",
        type = "event",
        url = "https://backstage.eu/magic-men-australia-in-munich-germany-10-05-2024.html",
        pkstatus = "62"
         }, new BackstageEvent {
                id = "65ca06b3b05ea",
        name = "MAGIC MEN AUSTRALIA IN MUNICH GERMANY",
        description = "Australia\u2019s BEST MALE DANCE GROUP",
        venue = "BACKSTAGE WERK",
        date = "05/11/2024",
        time = "22:00",
        type = "event",
        url = "https://backstage.eu/magic-men-australia-in-munich-germany-10-05-2024.html",
        pkstatus = "62"
         }, new BackstageEvent {
                id = "65ca06b3b0ab5",
        name = "MAGIC MEN AUSTRALIA IN MUNICH GERMANY",
        description = "Australia\u2019s BEST MALE DANCE GROUP",
        venue = "BACKSTAGE WERK",
        date = "05/12/2024",
        time = "19:30",
        type = "event",
        url = "https://backstage.eu/magic-men-australia-in-munich-germany-10-05-2024.html",
        pkstatus = "62"
         }, new BackstageEvent {
                id = "65ca06b3b1cf4",
        name = "STORM SEEKER - Live 2024",
        description = "Pirate Folk Metal",
        venue = "BACKSTAGE CLUB",
        date = "03/21/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/storm-seeker-live-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b3b3367",
        name = "MONO INC. - Symphonic Tour 2024 | ausverkauft",
        description = "Dark Rock",
        venue = "St. MATTH\u00c4US KIRCHE",
        date = "04/13/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/mono-inc-symphonic-tour-2024.html",
        pkstatus = "49"
         }, new BackstageEvent {
                id = "65ca06b3b4d87",
        name = "LORD OF THE LOST - 15 YEARS OF LORD OF THE LOST",
        description = "Dark Rock",
        venue = "BACKSTAGE WERK",
        date = "03/23/2024",
        time = "19:00",
        type = "event",
        url = "https://backstage.eu/lord-of-the-lost-15-years-of-lord-of-the-lost.html",
        pkstatus = "62"
         }, new BackstageEvent {
                id = "65ca06b3b66b8",
        name = "COVEN - Magickal Chaos Europe Tour 2023 | abgesagt",
        description = "<p>Hard Rock, Occult Rock</p>",
        venue = "",
        date = "03/05/2024",
        time = "",
        type = "event",
        url = "https://backstage.eu/coven-magickal-chaos-europe-tour-2023.html",
        pkstatus = "50",
        color = "#ff0000",
        badge = "Veranstaltung wurde abgesagt!"
         }, new BackstageEvent {
                id = "65ca06b3b7d90",
        name = "FENZL & BAND - Live 2024 | verlegt auf den 23.11.24",
        description = "Rock ",
        venue = "",
        date = "11/09/2024",
        time = "",
        type = "event",
        url = "https://backstage.eu/fenzl-band-live-2024.html",
        pkstatus = "58",
        color = "#ff0000",
        badge = "Veranstaltung wurde verlegt!"
         }, new BackstageEvent {
                id = "65ca06b3b8855",
        name = "FENZL & BAND - Live 2024 | verlegt auf den 23.11.24",
        description = "Rock ",
        venue = "BACKSTAGE CLUB",
        date = "11/23/2024",
        time = "19:15",
        type = "event",
        url = "https://backstage.eu/fenzl-band-live-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b3b9e7e",
        name = "NKSN - \"Come Over Tour 2024\" | verlegt auf den 02.06.24",
        description = "Rap",
        venue = "BACKSTAGE CLUB",
        date = "06/02/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/nksn-come-over-tour-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b3bb5f8",
        name = "MANNTRA - WAR OF THE HEATHENS TOUR",
        description = "Rock",
        venue = "BACKSTAGE CLUB",
        date = "03/16/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/manntra-war-of-the-heathens-tour.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b3bce31",
        name = "KASALLA - Rudeldiere Tour 2024",
        description = "Rock",
        venue = "BACKSTAGE WERK",
        date = "04/11/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/kasalla-rudeldiere-tour-2024.html",
        pkstatus = "62"
         }, new BackstageEvent {
                id = "65ca06b3be71e",
        name = "ROGERS - Rambazamba & Randale 2024",
        description = "Punkrock",
        venue = "BACKSTAGE HALLE",
        date = "03/23/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/rogers-rambazamba-randale-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b3bfc8a",
        name = "FILTER - European Tour 2024",
        description = "Rock",
        venue = "BACKSTAGE HALLE",
        date = "03/22/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/filter-european-tour-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b3c1405",
        name = "SCHATTENMANN - DIA DE MUERTOS TOUR",
        description = "NDH",
        venue = "BACKSTAGE HALLE",
        date = "03/21/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/schattenmann-dia-de-muertos-tour.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b3c2858",
        name = "ANY GIVEN DAY - LIMITLESS TOUR 2024 | ausverkauft",
        description = "Metalcore",
        venue = "BACKSTAGE HALLE",
        date = "02/17/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/any-given-day-limitless-tour-2024.html",
        pkstatus = "49"
         }, new BackstageEvent {
                id = "65ca06b3c40e9",
        name = "THRICE - Live 2024",
        description = "Post Hardcore",
        venue = "BACKSTAGE WERK",
        date = "02/20/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/thrice-live-2024.html",
        pkstatus = "62"
         }, new BackstageEvent {
                id = "65ca06b3c5771",
        name = "BONAPARTE - The Quiet & The Riot Tour",
        description = "Visual Trash Punk",
        venue = "BACKSTAGE WERK",
        date = "02/16/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/bonaparte-the-quiet-the-riot-tour.html",
        pkstatus = "62"
         }, new BackstageEvent {
                id = "65ca06b3c6ce7",
        name = "HARP TWINS feat. Volfgang Twins",
        description = "Mittelalter Rock, Metal, Folk, Cover, Harfe",
        venue = "BACKSTAGE CLUB",
        date = "02/27/2024",
        time = "19:30",
        type = "event",
        url = "https://backstage.eu/harp-twins-feat-volfgang-twins.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b3c85e1",
        name = "PAJEL - LONLEE TOUR 2024 |\u00a0leider abgesagt",
        description = "Rap",
        venue = "",
        date = "02/16/2024",
        time = "",
        type = "event",
        url = "https://backstage.eu/pajel-lonlee-tour-2024.html",
        pkstatus = "50",
        color = "#ff0000",
        badge = "Veranstaltung wurde abgesagt!"
         }, new BackstageEvent {
                id = "65ca06b3c9948",
        name = "Liz - \u201eGangster Tanzen Doch Tour' 2024 | verlegt auf den 02.04.24",
        description = "Rap",
        venue = "BACKSTAGE CLUB",
        date = "04/02/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/liz-gangster-tanzen-doch-tour-2024.html",
        pkstatus = "62"
         }, new BackstageEvent {
                id = "65ca06b3cac47",
        name = "WARKINGS - For King And Crown Tour",
        description = "Power Metal",
        venue = "BACKSTAGE HALLE",
        date = "04/18/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/warkings-for-king-and-crown-tour.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b3cbd59",
        name = "10 JAHRE SWISS & DIE ANDERN - ERSTMAL ZU PENNY TOUR 2024",
        description = "Punkrock, Crossover",
        venue = "TonHalle (Werksviertel-Mitte)",
        date = "05/10/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/10-jahre-swiss-die-andern-erstmal-zu-penny-tour-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b3cd015",
        name = "FEUERSCHWANZ - FEGEFEUER TOUR 2024",
        description = "Mittelalter Rock",
        venue = "BACKSTAGE WERK",
        date = "04/20/2024",
        time = "19:00",
        type = "event",
        url = "https://backstage.eu/feuerschwanz-fegefeuer-tour-2024.html",
        pkstatus = "62"
         }, new BackstageEvent {
                id = "65ca06b3ce6e8",
        name = "THE GARDENER & THE TREE - Silver Lining Tour",
        description = "Indie-Folk",
        venue = "BACKSTAGE WERK",
        date = "02/15/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/the-gardener-the-tree-live-2023.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b3cfa54",
        name = "FAROON - REVENGE TOUR 2024 | verlegt auf den 19.12.24 ",
        description = "Rap",
        venue = "",
        date = "02/23/2024",
        time = "",
        type = "event",
        url = "https://backstage.eu/faroon-revenge-tour-2024.html",
        pkstatus = "58",
        color = "#ff0000",
        badge = "Veranstaltung wurde verlegt!"
         }, new BackstageEvent {
                id = "65ca06b3d0559",
        name = "FAROON - REVENGE TOUR 2024 | verlegt auf den 19.12.24 ",
        description = "Rap",
        venue = "BACKSTAGE HALLE",
        date = "12/19/2024",
        time = "19:00",
        type = "event",
        url = "https://backstage.eu/faroon-revenge-tour-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b3d19af",
        name = "EDDIN - \u201eDU FEHLST TOUR 2024' | Verlegt auf den 06.09.24",
        description = null,
        venue = "BACKSTAGE WERK",
        date = "09/06/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/eddin-du-fehlst-tour-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b3d3194",
        name = "FISCHER-Z - Live 2024",
        description = "Rock",
        venue = "BACKSTAGE WERK",
        date = "04/29/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/fischer-z-live-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b3d47ff",
        name = "FORCED TO MODE & EKLIPSE - one caress",
        description = "Rock",
        venue = "BACKSTAGE WERK",
        date = "02/21/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/forced-to-mode-eklipse-one-caress.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b3d5f6c",
        name = "ALEX DIEHL - Live 2024",
        description = "Singer Songwriter ",
        venue = "BACKSTAGE CLUB",
        date = "03/08/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/alex-diehl-live-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b3d7224",
        name = "GROWL BOWL FESTIVAL 2024",
        description = "Metal",
        venue = "BACKSTAGE HALLE",
        date = "03/02/2024",
        time = "17:00",
        type = "event",
        url = "https://backstage.eu/growl-bowl-festival-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b3d831b",
        name = "ZYMBA - Ready For Take Off Tour 2024",
        description = "Rap",
        venue = "BACKSTAGE CLUB",
        date = "04/13/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/zymba-ready-for-take-off-tour-2024.html",
        pkstatus = "62"
         }, new BackstageEvent {
                id = "65ca06b3d954b",
        name = "BEYOND THE BLACK - Dancing In The Dark Tour 2024",
        description = "Symphonic-Metal",
        venue = "TonHalle (Werksviertel-Mitte)",
        date = "04/05/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/beyond-the-black-live-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b3da748",
        name = "TURBOBIER - \u201eNobel geht die Welt zugrund' - Tour 2024",
        description = "Rock",
        venue = "BACKSTAGE WERK",
        date = "03/02/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/turbobier-live-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b3dbd2d",
        name = "JINI MEYER - Live mit Band",
        description = "Rock",
        venue = "BACKSTAGE HALLE",
        date = "04/26/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/jini-meyer-live-mit-band.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b3dd172",
        name = "AchtVier - Fucking Fizzle Tour 2024",
        description = "Rap",
        venue = "BACKSTAGE CLUB",
        date = "04/18/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/achtvier-fucking-fizzle-tour-2024.html",
        pkstatus = "62"
         }, new BackstageEvent {
                id = "65ca06b3de7d9",
        name = "NULLSECHSROY - ich wollte dir noch sagen... tour '23 | verlegt auf den 14.04.24",
        description = "Rap",
        venue = "BACKSTAGE CLUB",
        date = "04/14/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/nullsechsroy-ich-wollte-dir-noch-sagen-tour-23.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b3df936",
        name = "LIONHEART - Welcome To The West Coast III",
        description = "Hardcore",
        venue = "BACKSTAGE WERK",
        date = "02/22/2024",
        time = "19:00",
        type = "event",
        url = "https://backstage.eu/lionheart-welcome-to-the-west-coast-iii.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b3e0b86",
        name = "BATTLE BEAST - Live 2024 | verlegt in die Muffathalle",
        description = "Heavy Metal",
        venue = "Muffatwerk",
        date = "02/15/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/battle-beast-live-2024.html",
        pkstatus = "62"
         }, new BackstageEvent {
                id = "65ca06b3e1e65",
        name = "MY'TALLICA - Tribute to Metallica",
        description = "Metallica Tribute Band",
        venue = "BACKSTAGE HALLE",
        date = "05/25/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/my-tallica-tribute-to-metallica.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b3e30c1",
        name = "METALLICA WEEKEND im BACKSTAGE",
        description = "4 Tage Metallica Fest",
        venue = "Backstage All Area",
        date = "05/23/2024",
        time = "21:00",
        type = "event",
        url = "https://backstage.eu/metallica-weekend-im-backstage.html",
        pkstatus = "61"
         }, new BackstageEvent {
                id = "65ca06b3e385e",
        name = "METALLICA WEEKEND im BACKSTAGE",
        description = "4 Tage Metallica Fest",
        venue = "Backstage All Area",
        date = "05/24/2024",
        time = "12:00",
        type = "event",
        url = "https://backstage.eu/metallica-weekend-im-backstage.html",
        pkstatus = "61"
         }, new BackstageEvent {
                id = "65ca06b3e3ca7",
        name = "METALLICA WEEKEND im BACKSTAGE",
        description = "4 Tage Metallica Fest",
        venue = "Backstage All Area",
        date = "05/25/2024",
        time = "14:00",
        type = "event",
        url = "https://backstage.eu/metallica-weekend-im-backstage.html",
        pkstatus = "61"
         }, new BackstageEvent {
                id = "65ca06b3e4132",
        name = "METALLICA WEEKEND im BACKSTAGE",
        description = "4 Tage Metallica Fest",
        venue = "Backstage All Area",
        date = "05/26/2024",
        time = "11:00",
        type = "event",
        url = "https://backstage.eu/metallica-weekend-im-backstage.html",
        pkstatus = "61"
         }, new BackstageEvent {
                id = "65ca06b3e558d",
        name = "ROCK ANTENNE METALLICA WARM UP PARTY",
        description = "Rock & Metal Party",
        venue = "BACKSTAGE CLUB",
        date = "05/23/2024",
        time = "21:00",
        type = "event",
        url = "https://backstage.eu/rock-antenne-metallica-warm-up-party.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b3e6db8",
        name = "METALLICA WARM UP BBQ",
        description = "Grillparty",
        venue = "Biergarten",
        date = "05/24/2024",
        time = "12:00",
        type = "event",
        url = "https://backstage.eu/metallica-warm-up-bbq.html",
        pkstatus = "61"
         }, new BackstageEvent {
                id = "65ca06b3e8728",
        name = "ROCK ANTENNE METALLICA AFTER SHOW PARTY | 24.05.",
        description = "Party ",
        venue = "BACKSTAGE HALLE",
        date = "05/24/2024",
        time = "23:00",
        type = "event",
        url = "https://backstage.eu/rock-antenne-metallica-after-show-party-24-05.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b3ea0cd",
        name = "THE DAY BETWEEN: GRILL 'EM ALL BBQ & ST. GERMANY FAN TREFFEN",
        description = "Übergangsl\u00f6sung am Offday",
        venue = "Biergarten",
        date = "05/25/2024",
        time = "14:00",
        type = "event",
        url = "https://backstage.eu/the-day-between-grill-em-all-bbq-st-germany-fan-treffen.html",
        pkstatus = "61"
         }, new BackstageEvent {
                id = "65ca06b3eb791",
        name = "METALLICA FREAK OUT PARTY",
        description = "After Show Party",
        venue = "Backstage",
        date = "05/25/2024",
        time = "23:00",
        type = "event",
        url = "https://backstage.eu/metallica-freak-out-party.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b3ecddc",
        name = "METALLICA WEISSWURSTFRÜHSCHOPPEN",
        description = "Warm Up Wurst",
        venue = "Biergarten",
        date = "05/26/2024",
        time = "11:00",
        type = "event",
        url = "https://backstage.eu/metallica-weisswurstfruhschoppen.html",
        pkstatus = "61"
         }, new BackstageEvent {
                id = "65ca06b3ee44f",
        name = "ROCK ANTENNE METALLICA AFTER SHOW PARTY | 26.05.",
        description = "After Show Party",
        venue = "BACKSTAGE CLUB",
        date = "05/26/2024",
        time = "23:00",
        type = "event",
        url = "https://backstage.eu/rock-antenne-metallica-after-show-party-26-05.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b3ef9b2",
        name = "U.D.O. - TOUCHDOWN World Tour 2023/24",
        description = "Metal",
        venue = "BACKSTAGE WERK",
        date = "03/03/2024",
        time = "19:15",
        type = "event",
        url = "https://backstage.eu/u-d-o-touchdown-world-tour-2023-24.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b3f12c7",
        name = "Go_A - Ukrainian Magic Tour 2024 | Nachholtermin vom 27.11.23",
        description = "ukrainian electro-folk",
        venue = "BACKSTAGE WERK",
        date = "05/08/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/go-a-live-2023.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b3f2b10",
        name = "RAUHBEIN -\u201eWIR SIND EINS' Tour 2024",
        description = "Folk Rock",
        venue = "BACKSTAGE HALLE",
        date = "04/02/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/rauhbein-wir-sind-eins-tour-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b3f4177",
        name = "NILS KEPPEL - Live 2024",
        description = "New Wave, NDW",
        venue = "Rote Sonne",
        date = "03/15/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/nils-keppel-live-2024.html",
        pkstatus = "62"
         }, new BackstageEvent {
                id = "65ca06b401810",
        name = "EMPATHY TEST - 10th anniversary tour 2014 - 2024",
        description = "Synthpop",
        venue = "BACKSTAGE HALLE",
        date = "03/15/2024",
        time = "19:30",
        type = "event",
        url = "https://backstage.eu/empathy-test-10th-anniversary-tour-2014-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b402ec0",
        name = "DEPECHE MODE Aftershowparty | 07.03.24",
        description = "Party ",
        venue = "BACKSTAGE WERK",
        date = "03/07/2024",
        time = "23:00",
        type = "event",
        url = "https://backstage.eu/depeche-mode-aftershowparty-07-03-24.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b4047c4",
        name = "NOW EX - Live 2024",
        description = "Alternative Pop",
        venue = "BACKSTAGE CLUB",
        date = "02/25/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/now-ex-live-2024.html",
        pkstatus = "62"
         }, new BackstageEvent {
                id = "65ca06b405fd1",
        name = "WIRTZ - DNA TOUR 2024",
        description = "Rock",
        venue = "BACKSTAGE WERK",
        date = "02/18/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/wirtz-dna-tour-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b407539",
        name = "FIDDLER'S GREEN - \"The Green Machine Tour\"",
        description = "Irish Speedfolk",
        venue = "BACKSTAGE WERK",
        date = "05/03/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/fiddler-s-green-the-green-machine-tour.html",
        pkstatus = "62"
         }, new BackstageEvent {
                id = "65ca06b408c54",
        name = "FREAK OUT - JEDEN SAMSTAG ",
        description = "Partyhard",
        venue = "Backstage All Area",
        date = "02/17/2024",
        time = "23:00",
        type = "event",
        url = "https://backstage.eu/freak-out-jeden-samstag.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b40950e",
        name = "FREAK OUT - JEDEN SAMSTAG ",
        description = "Partyhard",
        venue = "Backstage All Area",
        date = "02/24/2024",
        time = "23:00",
        type = "event",
        url = "https://backstage.eu/freak-out-jeden-samstag.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b40aad7",
        name = "MASSIVE WAGONS - Live in Europe 2024",
        description = "Rock",
        venue = "BACKSTAGE HALLE",
        date = "03/25/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/massive-wagons-live-in-europe-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b40c070",
        name = "DYMYTRY - Five Angry Men Tour",
        description = "Metal",
        venue = "BACKSTAGE CLUB",
        date = "03/09/2024",
        time = "19:45",
        type = "event",
        url = "https://backstage.eu/dymytry-five-angry-men-tour.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b40d7a5",
        name = "DARIUS RUCKER - Starting Fires Tour",
        description = "Rock, Country",
        venue = "BACKSTAGE WERK",
        date = "04/22/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/darius-rucker-starting-fires-tour.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b40f003",
        name = "FIREWIND & MASTERPLAN - Masters of Fire Tour 2024",
        description = "Power Metal",
        venue = "BACKSTAGE HALLE",
        date = "03/11/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/firewind-masterplan-masters-of-fire-tour-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b410828",
        name = "CCOSMO - Live 2024",
        description = "Pop, Rap",
        venue = "BACKSTAGE CLUB",
        date = "02/14/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/ccosmo-live-2024.html",
        pkstatus = "62"
         }, new BackstageEvent {
                id = "65ca06b411fae",
        name = "JOACHIM WITT  - \"Der Fels in der Brandung - Tour 2024\"",
        description = "Pop",
        venue = "BACKSTAGE HALLE",
        date = "04/12/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/joachim-witt-der-fels-in-der-brandung-tour-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b4138f5",
        name = "VERSENGOLD - LAUTES GEDENKEN TOUR 2024",
        description = "Folk Rock",
        venue = "BACKSTAGE WERK",
        date = "03/14/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/versengold-lautes-gedenken-tour-2024.html",
        pkstatus = "62"
         }, new BackstageEvent {
                id = "65ca06b4151af",
        name = "VITA - BENIMM DICH TOUR 2024",
        description = "HipHop",
        venue = "BACKSTAGE CLUB",
        date = "05/16/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/vita-benimm-dich-tour-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b416b15",
        name = "FRANKIE STEW & HARVEY GUNN - (Some of) The World Tour 2024",
        description = "Rap",
        venue = "BACKSTAGE HALLE",
        date = "02/19/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/frankie-stew-harvey-gunn-some-of-the-world-tour-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b4183a6",
        name = "ANCHORS & HEARTS \"Deathlist Tour 2024 \"",
        description = "Melodic-Hardcore",
        venue = "BACKSTAGE CLUB",
        date = "04/19/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/anchors-hearts-deathlist-tour-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b419f0f",
        name = "DARK EASTER METAL MEETING \u2013 2024",
        description = "Metal",
        venue = "Backstage",
        date = "03/30/2024",
        time = "14:30",
        type = "event",
        url = "https://backstage.eu/dark-easter-metal-meeting-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b41aa2a",
        name = "DARK EASTER METAL MEETING \u2013 2024",
        description = "Metal",
        venue = "Backstage",
        date = "03/31/2024",
        time = "14:30",
        type = "event",
        url = "https://backstage.eu/dark-easter-metal-meeting-2024.html",
        pkstatus = "51"
         }, new BackstageEvent {
                id = "65ca06b41c2d4",
        name = "BLIND CHANNEL \"EXIT EMOTIONS EUROPEAN TOUR 2024\"",
        description = "Post-Hardcore ",
        venue = "BACKSTAGE WERK",
        date = "03/27/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/blind-channel-exit-emotions-european-tour-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b41db5e",
        name = "FEUERSCHWANZ - FEGEFEUER TOUR 2024 |\u00a0Zusatzshow",
        description = "Mittelalter Rock",
        venue = "BACKSTAGE WERK",
        date = "04/21/2024",
        time = "19:00",
        type = "event",
        url = "https://backstage.eu/feuerschwanz-fegefeuer-tour-2024-zusatzshow.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b41f6a2",
        name = "SAIM x CAN \"Slime Society Tour 2024\" |\u00a0abgesagt",
        description = "Rap ",
        venue = "",
        date = "02/19/2024",
        time = "",
        type = "event",
        url = "https://backstage.eu/saim-x-can-slime-society-tour-2024.html",
        pkstatus = "50",
        color = "#ff0000",
        badge = "Veranstaltung wurde abgesagt!"
         }, new BackstageEvent {
                id = "65ca06b420e3a",
        name = "LANDMVRKS LIVE IN MUNICH",
        description = "Metalcore",
        venue = "BACKSTAGE WERK",
        date = "04/30/2024",
        time = "19:00",
        type = "event",
        url = "https://backstage.eu/landmvrks-live-in-munich.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b422879",
        name = "FINN & JONAS - Kiosk -Tour 2024",
        description = "Indie-Pop",
        venue = "BACKSTAGE CLUB",
        date = "03/20/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/finn-jonas-kiosk-tour-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b4245e4",
        name = "Vanaheim \"Aus Stein Geschlagen Tour 2024\"",
        description = "Pagan/Volk Metal",
        venue = "BACKSTAGE CLUB",
        date = "04/04/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/vanaheim-aus-stein-geschlagen-tour-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b426274",
        name = "THE CLOCKWORKS",
        description = "<p>Post Punk</p>",
        venue = "BACKSTAGE CLUB",
        date = "03/23/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/the-clockworks.html",
        pkstatus = "62"
         }, new BackstageEvent {
                id = "65ca06b427d3d",
        name = "KMPFSPRT - Tour 2024",
        description = "Punk ",
        venue = "BACKSTAGE CLUB",
        date = "06/08/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/kmpfsprt-tour-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b4298d1",
        name = "POLARIS \"2024 European Tour\"",
        description = "Metalcore ",
        venue = "BACKSTAGE WERK",
        date = "03/16/2024",
        time = "19:00",
        type = "event",
        url = "https://backstage.eu/polaris-2024-european-tour.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b42b387",
        name = "MUSSO - GAME 6 TOUR",
        description = "Deutschrap",
        venue = "BACKSTAGE WERK",
        date = "02/17/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/musso-game-6-tour.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b42cd35",
        name = "LUNE \"LUMI\u00c8RE TOUR 2024\"",
        description = "Deutsch Rap ",
        venue = "BACKSTAGE WERK",
        date = "11/23/2024",
        time = "19:00",
        type = "event",
        url = "https://backstage.eu/lune-lumiere-tour-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b42e73a",
        name = "John J. Presley \" Charos & Calypso Tour\"",
        description = "Blues ",
        venue = "BACKSTAGE CLUB",
        date = "03/11/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/john-j-presley-charos-calypso-tour.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b43017f",
        name = "EKTOMORF VIVID BLACK over Europe Tournee",
        description = "Trash Metal ",
        venue = "BACKSTAGE HALLE",
        date = "03/28/2024",
        time = "19:20",
        type = "event",
        url = "https://backstage.eu/ektomorf-vivid-black-over-europe-tournee.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b431a55",
        name = "REBELLION TOUR 2024",
        description = "Oldschool Hardcore ",
        venue = "BACKSTAGE WERK",
        date = "03/06/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/rebellion-tour-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b432efc",
        name = "QUERBEAT - Live 2024",
        description = "Future Brass Punk.",
        venue = "BACKSTAGE WERK",
        date = "03/08/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/querbeat-live-2024.html",
        pkstatus = "62"
         }, new BackstageEvent {
                id = "65ca06b434890",
        name = "CIVO - TOUR 2024",
        description = "RAP",
        venue = "BACKSTAGE HALLE",
        date = "04/19/2024",
        time = "19:00",
        type = "event",
        url = "https://backstage.eu/civo-tour-2024.html",
        pkstatus = "62"
         }, new BackstageEvent {
                id = "65ca06b436091",
        name = "MILJ\u00d6 - TOUR 2\u00d624",
        description = "K\u00f6lschrock",
        venue = "BACKSTAGE HALLE",
        date = "09/28/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/miljo-tour-2o24.html",
        pkstatus = "62"
         }, new BackstageEvent {
                id = "65ca06b43785f",
        name = "DILLA - \"ALSO BIN ICH (AUF) TOUR\"",
        description = "Pop",
        venue = "BACKSTAGE WERK",
        date = "03/04/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/dilla-also-bin-ich-auf-tour.html",
        pkstatus = "62"
         }, new BackstageEvent {
                id = "65ca06b438fd5",
        name = "PETRA SCHEESER&BAND - Anime Hits in Concert | ausverkauft",
        description = "Anime Hits",
        venue = "BACKSTAGE WERK",
        date = "04/14/2024",
        time = "19:00",
        type = "event",
        url = "https://backstage.eu/petra-scheeser-band-anime-hits-in-concert.html",
        pkstatus = "49"
         }, new BackstageEvent {
                id = "65ca06b43a804",
        name = "HI! SPENCER - \"Oben\" Tour 2024",
        description = "Rock",
        venue = "BACKSTAGE CLUB",
        date = "05/19/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/hi-spencer-oben-tour-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b43c0d9",
        name = "NOVELISTS - LIVE IN MUNICH",
        description = "Metalcore",
        venue = "BACKSTAGE HALLE",
        date = "02/26/2024",
        time = "19:00",
        type = "event",
        url = "https://backstage.eu/novelists-live-in-munich.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b43d989",
        name = "CHILDHOODNITES - Disney/Nick Party",
        description = "Back to our golden childhood",
        venue = "BACKSTAGE WERK",
        date = "05/24/2024",
        time = "22:00",
        type = "event",
        url = "https://backstage.eu/childhoodnites-disney-nick-party.html",
        pkstatus = "62"
         }, new BackstageEvent {
                id = "65ca06b43f4f8",
        name = "Rawayana |\u00a0Quien Trae las cornetas?",
        description = "Funk Pop Raggea ",
        venue = "BACKSTAGE WERK",
        date = "04/02/2024",
        time = "21:00",
        type = "event",
        url = "https://backstage.eu/rawayana-quien-trae-las-cornetas.html",
        pkstatus = "62"
         }, new BackstageEvent {
                id = "65ca06b4407ce",
        name = "Scala & Kolacny Brothers - Gloaming",
        description = "Frauenchor, Pop, Rock",
        venue = "BACKSTAGE WERK",
        date = "11/05/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/scala-kolacny-brothers-gloaming.html",
        pkstatus = "62"
         }, new BackstageEvent {
                id = "65ca06b441918",
        name = "RAVE THE REQVIEM - Ex-Eden Tour | abgesagt",
        description = "Alternative Metal",
        venue = "",
        date = "02/18/2024",
        time = "",
        type = "event",
        url = "https://backstage.eu/rave-the-reqviem-ex-eden-tour.html",
        pkstatus = "50",
        color = "#ff0000",
        badge = "Veranstaltung wurde abgesagt!"
         }, new BackstageEvent {
                id = "65ca06b442a57",
        name = "LORDI - UNLIVING PICTOUR SHOW 2024",
        description = "Hard Rock",
        venue = "BACKSTAGE WERK",
        date = "04/27/2024",
        time = "19:00",
        type = "event",
        url = "https://backstage.eu/lordi-unliving-pictour-show-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b443b30",
        name = "GRIMA - Live 2024",
        description = "Black Metal",
        venue = "BACKSTAGE HALLE",
        date = "05/02/2024",
        time = "19:30",
        type = "event",
        url = "https://backstage.eu/grima-live-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b444c45",
        name = "DISILLUSION - Live 2024",
        description = "Metal",
        venue = "BACKSTAGE CLUB",
        date = "05/03/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/disillusion-live-2024.html",
        pkstatus = "62"
         }, new BackstageEvent {
                id = "65ca06b445ecb",
        name = "NESS - Tour 2024",
        description = "Pop",
        venue = "BACKSTAGE HALLE",
        date = "10/22/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/ness-tour-2024.html",
        pkstatus = "62"
         }, new BackstageEvent {
                id = "65ca06b447329",
        name = "FINAL STAIR - Under Fire Tour 2024",
        description = "Rock",
        venue = "BACKSTAGE CLUB",
        date = "03/27/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/final-stair-under-fire-tour-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b4489e6",
        name = "LOS BRUDALOS - Live 2024",
        description = "Rap",
        venue = "BACKSTAGE HALLE",
        date = "11/09/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/los-brudalos-live-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b449ba0",
        name = "CARNIFEX + REVOCATION + ABORTED + VEXED",
        description = "Deathcore",
        venue = "Technikum",
        date = "03/31/2024",
        time = "18:30",
        type = "event",
        url = "https://backstage.eu/carnifex-revocation-aborted-vexed.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b44b1d7",
        name = "MONEY BOY - Live 2024",
        description = "<p>Rap</p>",
        venue = "BACKSTAGE WERK",
        date = "04/05/2024",
        time = "20:30",
        type = "event",
        url = "https://backstage.eu/money-boy-live-2024.html",
        pkstatus = "62"
         }, new BackstageEvent {
                id = "65ca06b44c6a9",
        name = "ZSK \"10 Jahre Herz für die Sache\"",
        description = "Punk",
        venue = "BACKSTAGE WERK",
        date = "05/04/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/zsk-10-jahre-herz-fur-die-sache.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b44d89f",
        name = "HELDMASCHINE - Fl\u00e4chenbrand Tour",
        description = "Rock, NDH",
        venue = "BACKSTAGE HALLE",
        date = "03/14/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/heldmaschine-flachenbrand-tour.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b44ec13",
        name = "HALFLIVES - INFERNO 2024 Tour",
        description = "Alternative Rock",
        venue = "BACKSTAGE CLUB",
        date = "03/13/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/halflives-inferno-2024-tour.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b45042d",
        name = "NACHTMAHR - Verboten! Tour 2024",
        description = "Industrial",
        venue = "BACKSTAGE HALLE",
        date = "11/16/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/nachtmahr-verboten-tour-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b451911",
        name = "IKKE HÜFTGOLD - Nummer Eins - Live Tour 2024",
        description = "Schlager",
        venue = "BACKSTAGE WERK",
        date = "11/29/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/ikke-huftgold-nummer-eins-live-tour-2024.html",
        pkstatus = "62"
         }, new BackstageEvent {
                id = "65ca06b45325a",
        name = "JOHN DIVA & THE ROCKETS OF LOVE - THE BIG EASY RELOADED",
        description = "Rock",
        venue = "BACKSTAGE HALLE",
        date = "03/09/2024",
        time = "19:30",
        type = "event",
        url = "https://backstage.eu/john-diva-the-rockets-of-love-the-big-easy-reloaded.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b454d83",
        name = "COLDRAIN - EURO TOUR 2024",
        description = "Post-Hardcore",
        venue = "BACKSTAGE HALLE",
        date = "03/03/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/coldrain-european-tour-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b4567a5",
        name = "SERENITY - SYMPHONIC METAL NIGHTS",
        description = "Symphonic Metal",
        venue = "BACKSTAGE HALLE",
        date = "02/14/2024",
        time = "19:30",
        type = "event",
        url = "https://backstage.eu/serenity-symphonic-metal-nights.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b457f1a",
        name = "GUTALAX - 15th Anniversary Tour 2024",
        description = "Gore 'n' Roll",
        venue = "BACKSTAGE HALLE",
        date = "10/20/2024",
        time = "19:30",
        type = "event",
        url = "https://backstage.eu/gutalax-15th-anniversary-tour-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b459280",
        name = "APSILON - Apsilon Live 2024",
        description = "Rap",
        venue = "BACKSTAGE HALLE",
        date = "11/13/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/apsilon-apsilon-live-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b45aa45",
        name = "STONEMAN - Neu! - Tour 2024",
        description = "Metal, NDH",
        venue = "BACKSTAGE CLUB",
        date = "09/05/2024",
        time = "19:30",
        type = "event",
        url = "https://backstage.eu/stoneman-neu-tour-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b45c087",
        name = "PERKELE - Tour 2024",
        description = "Rock",
        venue = "BACKSTAGE WERK",
        date = "09/14/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/perkele-tour-2024.html",
        pkstatus = "62"
         }, new BackstageEvent {
                id = "65ca06b45d71f",
        name = "CYNIC & OBSCURA - THE FOCUS OF A VALEDICTION European Tour 2024",
        description = "Metal",
        venue = "BACKSTAGE HALLE",
        date = "03/26/2024",
        time = "19:30",
        type = "event",
        url = "https://backstage.eu/cynic-obscura-the-focus-of-a-valediction-european-tour-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b45ec11",
        name = "ERDLING - Mein Element - Die 10 Jahre Jubil\u00e4umstournee 2024",
        description = "Metal, NDH",
        venue = "BACKSTAGE HALLE",
        date = "11/21/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/erdling-mein-element-die-10-jahre-jubilaumstournee-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b46028a",
        name = "KUPFERGOLD - Lichtermeer Tour 2024",
        description = "Folk Rock",
        venue = "BACKSTAGE CLUB",
        date = "04/06/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/kupfergold-lichtermeer-tour-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b461930",
        name = "OHRENFEINDT - WENN DER TEUFEL ANRUFT - TOUR 2024 ",
        description = "Rock",
        venue = "BACKSTAGE HALLE",
        date = "03/16/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/ohrenfeindt-tour-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b462feb",
        name = "CYPECORE - LEAGUE OF DISTORTION TOUR 2124",
        description = "Melodic Death Metal",
        venue = "BACKSTAGE HALLE",
        date = "04/27/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/cypecore-league-of-distortion-tour-2124.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b464986",
        name = "HELL BOULEVARD - Requiem Tour 2024",
        description = "Dark Rock",
        venue = "BACKSTAGE CLUB",
        date = "04/28/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/hell-boulevard-requiem-tour-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b466135",
        name = "STAHLMANN - PHOSPHOR TOUR ",
        description = "Rock, NDH",
        venue = "BACKSTAGE HALLE",
        date = "05/03/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/stahlmann-tour-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b4678f5",
        name = "GLENN HUGHES - 50 Years Burn Album Tour 2024",
        description = "Rock",
        venue = "BACKSTAGE WERK",
        date = "05/02/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/glenn-hughes-50-years-burn-album-tour-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b4696e1",
        name = "dieserBuddha - Buddha mittendrin - Tour",
        description = "Rap",
        venue = "BACKSTAGE CLUB",
        date = "03/14/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/dieserbuddha-buddha-mittendrin-tour.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b46ad73",
        name = "LX & MAXWELL - OBSTSTAND III TOUR",
        description = "Rap",
        venue = "BACKSTAGE WERK",
        date = "03/21/2024",
        time = "19:30",
        type = "event",
        url = "https://backstage.eu/lx-maxwell-obststand-iii-tour.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b46c558",
        name = "DIRTY HONEY - Can\u2019t Find The Brakes!! Tour EU + UK",
        description = "Hard Rock",
        venue = "BACKSTAGE HALLE",
        date = "03/05/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/dirty-honey-can-t-find-the-brakes-tour-eu-uk.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b46deb0",
        name = "THE PLOT IN YOU - UK / EUROPE 2024",
        description = "Metalcore",
        venue = "BACKSTAGE WERK",
        date = "09/13/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/the-plot-in-you-uk-europe-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b46fcd5",
        name = "OCHMONEKS - Unbesiegbar Tour 2024",
        description = "Punkrock",
        venue = "BACKSTAGE CLUB",
        date = "10/05/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/ochmoneks-unbesiegbar-tour-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b4713f3",
        name = "OLEXESH X CELO & ABDI - TOUR 2024",
        description = "Rap",
        venue = "BACKSTAGE WERK",
        date = "05/17/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/olexesh-x-celo-abdi-tour-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b472696",
        name = "MILLIARDEN - Tour 2024",
        description = "Rock",
        venue = "BACKSTAGE HALLE",
        date = "11/22/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/milliarden-tour-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b473a19",
        name = "CARDINAL BLACK - January Came Close Europe 2024",
        description = "Soul-Pop",
        venue = "BACKSTAGE CLUB",
        date = "02/28/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/cardinal-black-january-came-close-europe-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b475197",
        name = "BLACK FOXXES - Live 2024",
        description = "Indie Rock ",
        venue = "BACKSTAGE HALLE",
        date = "02/22/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/black-foxxes-live-2024.html",
        pkstatus = "62"
         }, new BackstageEvent {
                id = "65ca06b4768b1",
        name = "BOOMBOX - European tour 2024",
        description = "Rock",
        venue = "BACKSTAGE WERK",
        date = "02/13/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/boombox-european-tour-2024.html",
        pkstatus = "62"
         }, new BackstageEvent {
                id = "65ca06b478291",
        name = "KASIMIR1441 - KAMIKASI TOUR 2024",
        description = "Rap",
        venue = "BACKSTAGE HALLE",
        date = "05/10/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/kasimir1441-kamikasi-tour-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b479b27",
        name = "KASI - Kasi f\u00e4hrt auf Tour 2024",
        description = "Indiepop",
        venue = "BACKSTAGE HALLE",
        date = "11/07/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/kasi-kasi-fahrt-auf-tour-2024.html",
        pkstatus = "62"
         }, new BackstageEvent {
                id = "65ca06b47b003",
        name = "TRiPKiD - LANG LEBE TRiPKiD Tour 2024",
        description = "Rock",
        venue = "BACKSTAGE HALLE",
        date = "05/11/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/tripkid-lang-lebe-tripkid-tour-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b47c5ce",
        name = "RYAN SHERIDAN - Spring Tour 24",
        description = "Indie",
        venue = "BACKSTAGE HALLE",
        date = "04/04/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/ryan-sheridan-spring-tour-24.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b47d6ed",
        name = "MIKE SINGER - Rush Tour",
        description = "Pop",
        venue = "BACKSTAGE HALLE",
        date = "04/10/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/mike-singer-rush-tour.html",
        pkstatus = "62"
         }, new BackstageEvent {
                id = "65ca06b47ecc5",
        name = "SHORELINE + ATTIC STORIES - Live 2024",
        description = "Punkrock",
        venue = "BACKSTAGE CLUB",
        date = "04/30/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/shoreline-attic-stories-live-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b480259",
        name = "FOURTY - KEIN ABITOUR \u201924",
        description = "Rap",
        venue = "BACKSTAGE HALLE",
        date = "04/15/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/fourty-kein-abitour-24.html",
        pkstatus = "62"
         }, new BackstageEvent {
                id = "65ca06b48187f",
        name = "SPORTFREUNDE STILLER - 20 Jahre Burli",
        description = "Rock",
        venue = "BACKSTAGE WERK",
        date = "05/07/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/sportfreunde-stiller-20-jahre-burli.html",
        pkstatus = "62"
         }, new BackstageEvent {
                id = "65ca06b483041",
        name = "PASADENA ROOF ORCHESTRA - The Great Gatsby Party",
        description = "Tanzmusik",
        venue = "BACKSTAGE CLUB",
        date = "03/22/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/pasadena-roof-orchestra-the-great-gatsby-party.html",
        pkstatus = "62"
         }, new BackstageEvent {
                id = "65ca06b484434",
        name = "ATTILA & BORN OF OSIRIS - The \"Angels & Villains\" Tour 2024",
        description = "Metalcore",
        venue = "BACKSTAGE HALLE",
        date = "03/18/2024",
        time = "19:00",
        type = "event",
        url = "https://backstage.eu/attila-born-of-osiris-the-angels-villains-tour-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b48576c",
        name = "PLANLOS - Taschen voller Glück Tour",
        description = "Punkrock",
        venue = "BACKSTAGE CLUB",
        date = "11/02/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/planlos-taschen-voller-gluck-tour.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b48702b",
        name = "PESTILENCE + CARNATION + BODYFARM - Black Death Over Europe 2024",
        description = "Death Metal",
        venue = "BACKSTAGE HALLE",
        date = "04/03/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/pestilence-carnation-bodyfarm-black-death-over-europe-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b488847",
        name = "Mr.Hurley und die Pulveraffen - 15 JAHRE AGGRO SHANTY",
        description = "Folk Rock",
        venue = "BACKSTAGE WERK",
        date = "11/09/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/mr-hurley-die-pulveraffen-ye-banished-privateers-live-24.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b48a19f",
        name = "MiA. - Hellsehen-Tour 2024",
        description = "Elektropop",
        venue = "BACKSTAGE WERK",
        date = "10/24/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/mia-hellsehen-tour-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b48ba39",
        name = "THE BEVIS FROND - Live 2024 | Nachholshow vom 16.04.24",
        description = "Alternative Rock",
        venue = "",
        date = "04/16/2024",
        time = "",
        type = "event",
        url = "https://backstage.eu/the-bevis-frond-live-2024.html",
        pkstatus = "58",
        color = "#ff0000",
        badge = "Veranstaltung wurde verlegt!"
         }, new BackstageEvent {
                id = "65ca06b48c328",
        name = "THE BEVIS FROND - Live 2024 | Nachholshow vom 16.04.24",
        description = "Alternative Rock",
        venue = "BACKSTAGE WERKSTATT - STUDIO",
        date = "04/26/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/the-bevis-frond-live-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b48d8a0",
        name = "TVINNA - Wings Of Ember Release Shows 2024",
        description = "Rock",
        venue = "BACKSTAGE CLUB",
        date = "05/25/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/tvinna-wings-of-ember-release-shows-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b48efbd",
        name = "MONSTERS OF LIEDERMACHING - Live in München",
        description = "Liedermacher",
        venue = "BACKSTAGE WERK",
        date = "04/03/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/monsters-of-liedermaching-live-in-munchen.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b490743",
        name = "25 JAHRE ASP - DIE ZUSAMMENKUNFT 3",
        description = "Rock",
        venue = "BACKSTAGE WERK",
        date = "11/03/2024",
        time = "17:40",
        type = "event",
        url = "https://backstage.eu/25-jahre-asp-die-zusammenkunft-3.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b4917ea",
        name = "Fritz & Monti \"Zugekokst & hackedicht\"",
        description = null,
        venue = "BACKSTAGE CLUB",
        date = "06/21/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/fritz-monti-zugekokst-hackedicht.html",
        pkstatus = "62"
         }, new BackstageEvent {
                id = "65ca06b492c76",
        name = "SPITE + BODYSNATCHER + BOUNDARIES + MOUTH OF WAR",
        description = "Metal, Hardcore",
        venue = "BACKSTAGE HALLE",
        date = "04/17/2024",
        time = "19:00",
        type = "event",
        url = "https://backstage.eu/spite-bodysnatcher-boundaries-great-american-ghost.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b49458a",
        name = "CR7Z  - Wind der Freiheit Tour 2024",
        description = "Rap",
        venue = "BACKSTAGE CLUB",
        date = "09/13/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/cr7z-wind-der-freiheit-tour-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b495e0d",
        name = "BOYSETSFIRE - Live 2024",
        description = "Post Hardcore",
        venue = "BACKSTAGE WERK",
        date = "10/02/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/boysetsfire-live-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b4975ed",
        name = "ESTIKAY - Live 2024",
        description = "Rap",
        venue = "BACKSTAGE CLUB",
        date = "05/05/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/estikay-live-2024.html",
        pkstatus = "62"
         }, new BackstageEvent {
                id = "65ca06b498612",
        name = "COPPELIUS - Schall & Rauch Tournee 2024",
        description = "Kammercore",
        venue = "BACKSTAGE HALLE",
        date = "10/04/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/coppelius-schall-rauch-tournee-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b49947b",
        name = "MIAMI YACINE - WELCOME TO MIAMI TOUR 2024",
        description = "Rap",
        venue = "BACKSTAGE CLUB",
        date = "11/19/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/miami-yacine-welcome-to-miami-tour-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b49a6c5",
        name = "HALLER - live in München",
        description = "Indie Pop",
        venue = "BACKSTAGE CLUB",
        date = "04/20/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/haller-live-in-munchen.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b49be3a",
        name = "JONATHAN ROY - Live 2024",
        description = "Pop",
        venue = "BACKSTAGE HALLE",
        date = "06/06/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/jonathan-roy-live-2024.html",
        pkstatus = "62"
         }, new BackstageEvent {
                id = "65ca06b49d687",
        name = "HAYSEED DIXIE - Maximum Rockgrass 2024",
        description = "Rock, Dixie, Grass",
        venue = "BACKSTAGE HALLE",
        date = "04/28/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/hayseed-dixie-maximum-rockgrass-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b49ef65",
        name = "AMERICAN PIE EMO NIGHT - an evening with THOMAS NICHOLAS",
        description = "Songs & Story Abend, Comedy",
        venue = "BACKSTAGE HALLE",
        date = "03/13/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/american-pie-emo-night-an-evening-with-thomas-nicholas.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b4a095d",
        name = "THERION - LEVIATHAN TOUR 2024",
        description = "Symphonic Metal",
        venue = "BACKSTAGE HALLE",
        date = "03/07/2024",
        time = "19:45",
        type = "event",
        url = "https://backstage.eu/therion-leviathan-tour-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b4a227e",
        name = "LIFE OF AGONY - UP CLOSE & UNPLUGGED",
        description = "Alternative-Metal",
        venue = "Backstage Arena",
        date = "02/16/2024",
        time = "19:00",
        type = "event",
        url = "https://backstage.eu/life-of-agony-up-close-unplugged.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b4a3ac7",
        name = "LEAVES\u00b4EYES - MYTHS OF FATE TOUR 2024",
        description = "Symphonic Metal",
        venue = "BACKSTAGE HALLE",
        date = "03/27/2024",
        time = "19:00",
        type = "event",
        url = "https://backstage.eu/leaves-eyes-myths-of-fate-tour-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b4a554f",
        name = "25. Schalldruck Festival (Rock & Classic Metal)",
        description = "Rock & Classic Metal",
        venue = "BACKSTAGE HALLE",
        date = "04/06/2024",
        time = "18:00",
        type = "event",
        url = "https://backstage.eu/25-schalldruck-festival-rock-classic-metal.html",
        pkstatus = "62"
         }, new BackstageEvent {
                id = "65ca06b4a7020",
        name = "CRYPTA - Shades Of Sorrow European Tour",
        description = "Death Metal",
        venue = "BACKSTAGE CLUB",
        date = "04/21/2024",
        time = "19:45",
        type = "event",
        url = "https://backstage.eu/crypta-shades-of-sorrow-european-tour.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b4a8975",
        name = "SEPULTURA - 40 YEARS FAREWELL TOUR \"CELEBRATING LIFE THROUGH DEATH\"",
        description = "Metal",
        venue = "Zenith ",
        date = "11/16/2024",
        time = "18:20",
        type = "event",
        url = "https://backstage.eu/sepultura-40-years.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b4aa434",
        name = "SHAKRA + ROCK OUT - Invincible Tour 2024",
        description = "<p>Hard Rock</p>",
        venue = "BACKSTAGE CLUB",
        date = "05/08/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/shakra-rock-out.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b4abf8a",
        name = "ALEXANDRA KAY + HANNAH ELLIS + LAKEVIEW - Live 2024",
        description = "Rock",
        venue = "BACKSTAGE CLUB",
        date = "03/06/2024",
        time = "19:00",
        type = "event",
        url = "https://backstage.eu/alexandra-kay-matt-schuster-lakeview-live-2024.html",
        pkstatus = "62"
         }, new BackstageEvent {
                id = "65ca06b4ad669",
        name = "VISIONS OF ATLANTIS - ARMADA TOUR",
        description = "Symphonic Metal",
        venue = "BACKSTAGE HALLE",
        date = "10/16/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/visions-of-atlantis-armada-tour.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b4af06c",
        name = "AND ONE - \"The Cover Lover Supershow 2\"",
        description = "Synth Pop",
        venue = "BACKSTAGE WERK",
        date = "10/19/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/and-one-the-cover-lover-supershow-2.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b4b0a5a",
        name = "SONS OF THE EAST - Live 2024",
        description = "Indie Folk",
        venue = "BACKSTAGE WERK",
        date = "06/15/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/sons-of-the-east-live-2024.html",
        pkstatus = "62"
         }, new BackstageEvent {
                id = "65ca06b4b2279",
        name = "BLOODRED HOURGLASS - How\u2019s The Heart? Tour",
        description = "Groove Metal",
        venue = "BACKSTAGE CLUB",
        date = "03/25/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/bloodred-hourglass-how-s-the-heart-tour.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b4b3c6c",
        name = "RIKU RAJAMAA - CLOSE TO YOU TOUR 2024 PART II",
        description = "Rock",
        venue = "BACKSTAGE CLUB",
        date = "09/27/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/riku-rajamaa-close-to-you-tour-2024-part-ii.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b4b55ac",
        name = "dArtagnan - Live 2024",
        description = "Mittelalter Rock",
        venue = "BACKSTAGE WERK",
        date = "07/11/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/dartagnan-live-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b4b6d7e",
        name = "MAIDENHEAD & FRIENDS - Live 2024",
        description = "Metal",
        venue = "BACKSTAGE HALLE",
        date = "10/18/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/maidenhead-friends-live-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b4b852b",
        name = "THE WARNING - Live 2024",
        description = "Rock",
        venue = "BACKSTAGE WERK",
        date = "04/13/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/the-warning-live-2024.html",
        pkstatus = "62"
         }, new BackstageEvent {
                id = "65ca06b4b9bc8",
        name = "JAMARAM meets JAHCOUSTIX  - Live 2024",
        description = "Reggae, Dub",
        venue = "BACKSTAGE WERK",
        date = "04/25/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/jamaram-live-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b4bb228",
        name = "FUN LOVIN\u00b4 CRIMINALS - The Capistrano Tour 2024",
        description = "Rock",
        venue = "BACKSTAGE HALLE",
        date = "04/24/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/fun-lovin-criminals-live-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b4bca5e",
        name = "YUNG KAFA & KÜCÜK EFENDI - Live in Concert",
        description = "Rap",
        venue = "BACKSTAGE WERK",
        date = "04/08/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/yung-kafa-kucuk-efendi-live-in-concert.html",
        pkstatus = "62"
         }, new BackstageEvent {
                id = "65ca06b4be244",
        name = "TEST VA 00003",
        description = null,
        venue = "Alte Kongresshalle",
        date = "12/07/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/test-va-00003.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b4bf94a",
        name = "JONA - Heartbreaks & Healing Tour 2024",
        description = null,
        venue = "BACKSTAGE CLUB",
        date = "04/17/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/jona-heartbreaks-healing-tour-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b4c10d7",
        name = "THEO JUNIOR - TR\u00c4NEN ZU DIAMANTEN TOUR 2024",
        description = null,
        venue = "BACKSTAGE CLUB",
        date = "03/07/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/theo-junior-tranen-zu-diamanten-tour-2024.html",
        pkstatus = "62"
         }, new BackstageEvent {
                id = "65ca06b4c2853",
        name = "KISP\u00c1L \u00c9S A BORZ - Live 2024",
        description = null,
        venue = "BACKSTAGE HALLE",
        date = "04/14/2024",
        time = "19:00",
        type = "event",
        url = "https://backstage.eu/kispal-es-a-borz-live-2024.html",
        pkstatus = "62"
         }, new BackstageEvent {
                id = "65ca06b4c3f98",
        name = "NEUNUNDNEUNZIG - DU SIEHST NEUNUNDNEUNZIG",
        description = "Rap",
        venue = "BACKSTAGE CLUB",
        date = "03/15/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/neunundneunzig-du-siehst-neunundneunzig.html",
        pkstatus = "62"
         }, new BackstageEvent {
                id = "65ca06b4c5769",
        name = "ELLENDE - Scherben Tour 2024",
        description = "Black Metal",
        venue = "BACKSTAGE HALLE",
        date = "10/02/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/ellende-scherben-tour-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b4c7165",
        name = "RAMI HATTAB* - WENN ICH TANZ TOUR 2024",
        description = "Pop, Folk",
        venue = "BACKSTAGE CLUB",
        date = "04/05/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/rami-hattab-wenn-ich-tanz-tour-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b4c8985",
        name = "BULLETPROOF - No Compromise Tour 2024",
        description = "Metal",
        venue = "BACKSTAGE CLUB",
        date = "04/23/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/bulletproof-no-compromise-tour-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b4ca1d5",
        name = "Zeke DEux - First time in Europe",
        description = "Metal",
        venue = "BACKSTAGE CLUB",
        date = "09/28/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/zeke-deux-first-time-in-europe.html",
        pkstatus = "62"
         }, new BackstageEvent {
                id = "65ca06b4cce94",
        name = "D-A-D - Live 2024",
        description = "Rock",
        venue = "BACKSTAGE WERK",
        date = "11/28/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/d-a-d-live-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b4ce572",
        name = "DORIAN - Taharia Tour 2024",
        description = "Pop",
        venue = "BACKSTAGE CLUB",
        date = "09/12/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/dorian-taharia-tour-2024.html",
        pkstatus = "62"
         }, new BackstageEvent {
                id = "65ca06b4cfa6b",
        name = "BATOMAE - \"Auf der Suche nach der Liebe\" - Live 2024",
        description = null,
        venue = "BACKSTAGE CLUB",
        date = "10/19/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/batomae-auf-der-suche-nach-der-liebe-live-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b4d0ade",
        name = "OMAH LAY - Live in Concert | ausverkauft",
        description = "Afrobeat",
        venue = "BACKSTAGE WERK",
        date = "02/12/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/omah-lay-live-in-concert.html",
        pkstatus = "49"
         }, new BackstageEvent {
                id = "65ca06b4d1a54",
        name = "J.B.O. - \"30 Jahre Explizite Lyrik\"",
        description = "Rock",
        venue = "BACKSTAGE WERK",
        date = "09/20/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/j-b-o-30-jahre-explizite-lyrik.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b4d2924",
        name = "THE KIFFNESS - Live 2024",
        description = "Rock",
        venue = "BACKSTAGE WERK",
        date = "09/18/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/the-kiffness-live-2024.html",
        pkstatus = "62"
         }, new BackstageEvent {
                id = "65ca06b4d3d54",
        name = "KEEP IT LOW FESTIVAL 2024 | 11.10.24 & 12.10.24",
        description = "Rock",
        venue = "Backstage All Area",
        date = "10/11/2024",
        time = "18:00",
        type = "event",
        url = "https://backstage.eu/keep-it-low-festival-2024-11-10-24-12-10-24.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b4d4659",
        name = "KEEP IT LOW FESTIVAL 2024 | 11.10.24 & 12.10.24",
        description = "Rock",
        venue = "Backstage All Area",
        date = "10/12/2024",
        time = "14:00",
        type = "event",
        url = "https://backstage.eu/keep-it-low-festival-2024-11-10-24-12-10-24.html",
        pkstatus = "51"
         }, new BackstageEvent {
                id = "65ca06b4d5ccd",
        name = "KIDS.DOC - Dr. Med. VITOR GATINHO",
        description = "Live-Podcast",
        venue = "Backstage Arena",
        date = "03/15/2024",
        time = "20:30",
        type = "event",
        url = "https://backstage.eu/kids-doc-dr-med-vitor-gatinho.html",
        pkstatus = "62"
         }, new BackstageEvent {
                id = "65ca06b4d7636",
        name = "QUERBEAT - Live 2024 | Zusatzshow",
        description = "Rock",
        venue = "BACKSTAGE WERK",
        date = "03/07/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/querbeat-live-2024-zusatzshow.html",
        pkstatus = "62"
         }, new BackstageEvent {
                id = "65ca06b4d8efd",
        name = "SUMMER STORM 2024",
        description = "Metal",
        venue = "BACKSTAGE CLUB",
        date = "06/14/2024",
        time = "17:00",
        type = "event",
        url = "https://backstage.eu/summer-storm-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b4da8fa",
        name = "DENNIS DIES DAS - Tour 2024",
        description = "Rap",
        venue = "Rote Sonne",
        date = "10/26/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/dennis-dies-das-tour-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b4dc0d6",
        name = "REGGAEVILLE EASTER SPECIAL 2024",
        description = "Reggae",
        venue = "BACKSTAGE WERK",
        date = "03/28/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/reggaeville-easter-special-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b4dd8c7",
        name = "DRITTE WAHL - Urlaub in der Bredouille",
        description = "Rock",
        venue = "BACKSTAGE WERK",
        date = "11/08/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/dritte-wahl-urlaub-in-der-bredouille.html",
        pkstatus = "62"
         }, new BackstageEvent {
                id = "65ca06b4df0a7",
        name = "STUDY HARD - PARTY HARDER - Q11/Q12 Party",
        description = "Q11/Q12 Party",
        venue = "BACKSTAGE WERK",
        date = "02/24/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/study-hard-party-harder-q11-q12-party.html",
        pkstatus = "62"
         }, new BackstageEvent {
                id = "65ca06b4e07dc",
        name = "TAUSEND ROSEN - Live 2024",
        description = "Pop",
        venue = "BACKSTAGE CLUB",
        date = "02/29/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/tausend-rosen-live-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b4e201d",
        name = "LAZIO ROM vs. FC BAYERN - Champions League 23/24",
        description = "Fussball Liveübertragung",
        venue = "BACKSTAGE WERK",
        date = "02/14/2024",
        time = "21:00",
        type = "event",
        url = "https://backstage.eu/lazio-vs-fc-bayern-champions-league-23-24.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b4e350d",
        name = "BOCHUM vs. FC BAYERN | Bundesliga 23/24",
        description = "Fussball Liveübertragung",
        venue = "REITKNECHT 6",
        date = "02/18/2024",
        time = "17:30",
        type = "event",
        url = "https://backstage.eu/bochum-vs-fc-bayern-bundesliga-23-24.html",
        pkstatus = "61"
         }, new BackstageEvent {
                id = "65ca06b4e4d0a",
        name = "FC BAYERN vs. RB LEIPZIG | Bundesliga 23/24",
        description = "Fussball Liveübertragung",
        venue = "REITKNECHT 6",
        date = "02/24/2024",
        time = "18:30",
        type = "event",
        url = "https://backstage.eu/fc-bayern-vs-rb-leipzig-bundesliga-23-24.html",
        pkstatus = "61"
         }, new BackstageEvent {
                id = "65ca06b4e66b1",
        name = "FC BAYERN vs. LAZIO ROM - Champions League 23/24",
        description = "Fussball Liveübertragung",
        venue = "REITKNECHT 6",
        date = "03/05/2024",
        time = "21:00",
        type = "event",
        url = "https://backstage.eu/fc-bayern-vs-lazio-rom-champions-league-23-24.html",
        pkstatus = "61"
         }, new BackstageEvent {
                id = "65ca06b4e7cff",
        name = "FC BAYERN vs. MAINZ | Bundesliga 23/24",
        description = "Fussball Liveübertragung",
        venue = "REITKNECHT 6",
        date = "03/09/2024",
        time = "15:30",
        type = "event",
        url = "https://backstage.eu/fc-bayern-vs-mainz-bundesliga-23-24.html",
        pkstatus = "61"
         }, new BackstageEvent {
                id = "65ca06b4e94a9",
        name = "DARMSTADT vs. FC BAYERN | Bundesliga 23/24",
        description = "Fussball Liveübertragung",
        venue = "REITKNECHT 6",
        date = "03/16/2024",
        time = "15:30",
        type = "event",
        url = "https://backstage.eu/darmstadt-vs-fc-bayern-bundesliga-23-24.html",
        pkstatus = "61"
         }, new BackstageEvent {
                id = "65ca06b4ea500",
        name = "MARDUK - EUROPEAN TOUR 2024",
        description = "Black Metal ",
        venue = "BACKSTAGE HALLE",
        date = "04/23/2024",
        time = "19:00",
        type = "event",
        url = "https://backstage.eu/marduk-european-tour-2024.html",
        pkstatus = "51"
         }, new BackstageEvent {
                id = "65ca06b4ec398",
        name = "BOPPIN`B - Live 2024",
        description = "Punk, Rock, Ska",
        venue = "BACKSTAGE CLUB",
        date = "12/13/2024",
        time = "20:30",
        type = "event",
        url = "https://backstage.eu/boppin-b-live-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b4ed9c5",
        name = "THE MODERN AGE SLAVERY - EUROPEAN TOUR 2024 | wird verlegt",
        description = "Heavy Metal",
        venue = "",
        date = "02/12/2024",
        time = "",
        type = "event",
        url = "https://backstage.eu/the-modern-age-slavery-european-tour-2024.html",
        pkstatus = "58",
        color = "#ff0000",
        badge = "Veranstaltung wurde verlegt!"
         }, new BackstageEvent {
                id = "65ca06b4ef1da",
        name = "THE ROCK `N\u00b4 ROLL WRESTLING BASH 2024",
        description = "Trash Wrestling",
        venue = "BACKSTAGE WERK",
        date = "12/28/2024",
        time = "19:30",
        type = "event",
        url = "https://backstage.eu/the-rock-n-roll-wrestling-bash-2024.html",
        pkstatus = "52"
         }, new BackstageEvent {
                id = "65ca06b4f0d1c",
        name = "CALO x MORPHEUZ x LOC 079 x MUFASA069 - Die Gipsy Tour",
        description = "Rap",
        venue = "BACKSTAGE HALLE",
        date = "05/19/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/calo-x-morpheus-x-loc-079-x-mufasa069-die-gipsy-tour.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b4f2622",
        name = "KREIML & SAMURAI - RANZ ODER GAR NICHT TOUR",
        description = "HipHop",
        venue = "BACKSTAGE CLUB",
        date = "05/22/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/kreiml-samurai-ranz-oder-gar-nicht-tour.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b4f4089",
        name = "ENTORIA - Albtraumnacht vol. 7",
        description = "Metal",
        venue = "BACKSTAGE HALLE",
        date = "05/04/2024",
        time = "19:00",
        type = "event",
        url = "https://backstage.eu/entoria-albtraumnacht-vol-7.html",
        pkstatus = "62"
         }, new BackstageEvent {
                id = "65ca06b501588",
        name = "MR. IRISH BASTARD - Battle Songs of the Damned Tour 2024",
        description = "Folk Punk",
        venue = "BACKSTAGE WERK",
        date = "03/17/2024",
        time = "19:00",
        type = "event",
        url = "https://backstage.eu/mr-irish-bastard-battle-songs-of-the-damned-tour-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b503115",
        name = "THE CASUALTIES - Europa Tour 2024",
        description = "Streetpunk",
        venue = "BACKSTAGE CLUB",
        date = "07/09/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/the-casualties-europa-tour-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b50491b",
        name = "UNLIMITED CULTURE - Live 2024",
        description = "Reggae",
        venue = "BACKSTAGE CLUB",
        date = "10/03/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/unlimited-culture-live-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b505d2b",
        name = "KA$HDAMI - Oasis European Tour",
        description = "Rap",
        venue = "BACKSTAGE CLUB",
        date = "03/26/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/ka-hdami-live-2024.html",
        pkstatus = "62"
         }, new BackstageEvent {
                id = "65ca06b5072cb",
        name = "BOWMEN & BAD RAIN - Double Headliner Konzert",
        description = "Rock",
        venue = "BACKSTAGE CLUB",
        date = "11/16/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/bowmen-bad-rain-double-headliner-konzert.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b50842b",
        name = "MATT HOLUBOWSKI - Like Flowers On A Molten Lawn",
        description = "Singer Songwriter",
        venue = "BACKSTAGE CLUB",
        date = "04/15/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/matt-holubowski-like-flowers-on-a-molten-lawn.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b50a2dc",
        name = "downset. - Live 2024",
        description = "Crossover",
        venue = "BACKSTAGE CLUB",
        date = "06/11/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/downset-live-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b50bbdc",
        name = "EMERGENZA MÜNCHEN 2024 - VORRUNDE 3",
        description = "Bandcontest",
        venue = "BACKSTAGE CLUB",
        date = "02/24/2024",
        time = "19:00",
        type = "event",
        url = "https://backstage.eu/emergenza-munchen-2024-vorrunde-3.html",
        pkstatus = "62"
         }, new BackstageEvent {
                id = "65ca06b50d0f3",
        name = "EMERGENZA MÜNCHEN 2024 - VORRUNDE 4",
        description = "Bandcontest",
        venue = "BACKSTAGE CLUB",
        date = "03/01/2024",
        time = "19:00",
        type = "event",
        url = "https://backstage.eu/emergenza-munchen-2024-vorrunde-4.html",
        pkstatus = "62"
         }, new BackstageEvent {
                id = "65ca06b50e730",
        name = "EMERGENZA MÜNCHEN 2024 - VORRUNDE 5",
        description = "Bandcontest",
        venue = "BACKSTAGE CLUB",
        date = "03/02/2024",
        time = "19:00",
        type = "event",
        url = "https://backstage.eu/emergenza-munchen-2024-vorrunde-5.html",
        pkstatus = "62"
         }, new BackstageEvent {
                id = "65ca06b50f896",
        name = "Night Market Spezial - All Good Things",
        description = "Flohmarkt",
        venue = "Backstage Arena",
        date = "03/01/2024",
        time = "17:00",
        type = "event",
        url = "https://backstage.eu/night-market-spezial-all-good-things.html",
        pkstatus = "62"
         }, new BackstageEvent {
                id = "65ca06b5100e1",
        name = "Night Market Spezial - All Good Things",
        description = "Flohmarkt",
        venue = "Backstage Arena",
        date = "03/02/2024",
        time = "17:00",
        type = "event",
        url = "https://backstage.eu/night-market-spezial-all-good-things.html",
        pkstatus = "62"
         }, new BackstageEvent {
                id = "65ca06b5114af",
        name = "MORTEN - El Camino Tour 2024",
        description = null,
        venue = "BACKSTAGE CLUB",
        date = "03/03/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/morten-el-camino-tour-2024.html",
        pkstatus = "62"
         }, new BackstageEvent {
                id = "65ca06b512c6b",
        name = "SAMORY I & MORTIMER MEET TIPPY I-GRADE",
        description = "Reggae",
        venue = "BACKSTAGE WERK",
        date = "03/09/2024",
        time = "21:00",
        type = "event",
        url = "https://backstage.eu/samory-i-mortimer-meet-tippy-i-grade.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b514133",
        name = "EXHORDER & NERVOSA - Live 2024",
        description = "Metal",
        venue = "BACKSTAGE HALLE",
        date = "05/23/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/exhorder-nervosa-live-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b5152ef",
        name = "RED - Rated R Tour 2024",
        description = "Rock",
        venue = "BACKSTAGE HALLE",
        date = "06/18/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/red-live-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b516937",
        name = "H-BLOCKX - Time To Move Anniversary - Tour 2024",
        description = "Crossover",
        venue = "BACKSTAGE WERK",
        date = "10/27/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/h-blockx-time-to-move-anniversary-tour-2024.html",
        pkstatus = "62"
         }, new BackstageEvent {
                id = "65ca06b51804f",
        name = "RONG KONG KOMA - Live 2024",
        description = "Rock",
        venue = "BACKSTAGE CLUB",
        date = "05/09/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/rong-kong-koma-live-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b519345",
        name = "THE HARDKISS - European Tour 2024",
        description = "Rock",
        venue = "BACKSTAGE WERK",
        date = "04/10/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/the-hardkiss-european-tour-2024.html",
        pkstatus = "62"
         }, new BackstageEvent {
                id = "65ca06b51a791",
        name = "DONDON - Live 2024",
        description = "Pop",
        venue = "BACKSTAGE HALLE",
        date = "12/13/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/dondon-live-2024.html",
        pkstatus = "62"
         }, new BackstageEvent {
                id = "65ca06b51bd90",
        name = "CALIGULA\u2019S HORSE - Live 2024",
        description = "Progressive-Metal",
        venue = "BACKSTAGE CLUB",
        date = "05/17/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/caligula-s-horse-live-2024.html",
        pkstatus = "62"
         }, new BackstageEvent {
                id = "65ca06b51d4d1",
        name = "HARDCORE SUPERSTAR - Live 2024",
        description = "Hardrock",
        venue = "BACKSTAGE WERK",
        date = "11/14/2024",
        time = "19:30",
        type = "event",
        url = "https://backstage.eu/hardcore-superstar-live-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b51e6fe",
        name = "PSYCLON NINE - Live 2024",
        description = "Heavy Metal",
        venue = "BACKSTAGE CLUB",
        date = "05/20/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/psyclon-nine-live-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b51fc97",
        name = "ALIENARE - Lumen Tour 2024",
        description = "Dark Wave",
        venue = "BACKSTAGE CLUB",
        date = "09/07/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/alienare-lumen-tour-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b520d59",
        name = "CENTINEX - DEAD FOREVER TOUR 2024",
        description = "Death Metal",
        venue = "BACKSTAGE CLUB",
        date = "05/21/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/centinex-dead-forever-tour-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b521e64",
        name = "ALKALINE TRIO - Live 2024",
        description = "Rock",
        venue = "BACKSTAGE WERK",
        date = "08/11/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/alkaline-trio-live-2024.html",
        pkstatus = "62"
         }, new BackstageEvent {
                id = "65ca06b5230d2",
        name = "REIS AGAINST THE SPÜLMACHINE - Live 2024",
        description = "Rock",
        venue = "BACKSTAGE CLUB",
        date = "10/17/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/reis-against-the-spulmachine-live-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b5249eb",
        name = "T-LOW - LITTY-WAY TOUR 2024",
        description = "Rap",
        venue = "BACKSTAGE WERK",
        date = "10/20/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/t-low-litty-way-tour-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b525e32",
        name = "SOLAR FAKE - DON\u00b4T PUSH THIS BUTTON TOUR 2024",
        description = "Synthpop",
        venue = "BACKSTAGE HALLE",
        date = "12/07/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/solar-fake-don-t-push-this-button.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b52712b",
        name = "AVAION \u2013 FOR THE VIBES SPRING TOUR 2024",
        description = "Electronic",
        venue = "BACKSTAGE CLUB",
        date = "05/14/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/avaion-for-the-vibes-spring-tour-2024.html",
        pkstatus = "62"
         }, new BackstageEvent {
                id = "65ca06b5288d1",
        name = "ARTEM PIVOVAROV - Live 2024",
        description = null,
        venue = "BACKSTAGE WERK",
        date = "02/23/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/artem-pivovarov-live-2024.html",
        pkstatus = "62"
         }, new BackstageEvent {
                id = "65ca06b529d30",
        name = "ETERNAL FLAMES OF UKRAINIAN RESISTANCE",
        description = "Metal, Charity",
        venue = "BACKSTAGE HALLE",
        date = "04/21/2024",
        time = "18:00",
        type = "event",
        url = "https://backstage.eu/eternal-flames-of-ukrainian-resistance.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b52b442",
        name = "BURIED ALIVE - UK/ EUROPEAN TOUR 2024",
        description = "Hardcore-Punk",
        venue = "BACKSTAGE CLUB",
        date = "03/12/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/buried-alive-uk-european-tour-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b52cbde",
        name = "SCHREYNER - Monsters of Rock - Tour 2025",
        description = "Rock",
        venue = "BACKSTAGE CLUB",
        date = "01/18/2025",
        time = "20:30",
        type = "event",
        url = "https://backstage.eu/schreyner-monsters-of-rock-tour-2025.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b52e4f8",
        name = "RICHIE KOTZEN - Live 2024",
        description = "Rock",
        venue = "BACKSTAGE HALLE",
        date = "06/28/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/richie-kotzen-live-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b52fe5b",
        name = "ROR-Reflection of Reality | LIVE 2024",
        description = "Rock",
        venue = "BACKSTAGE CLUB",
        date = "05/10/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/ror-reflection-of-reality-live-2024.html",
        pkstatus = "62"
         }, new BackstageEvent {
                id = "65ca06b531464",
        name = "COLDHEART - Rock Classics",
        description = "Rock ",
        venue = "BACKSTAGE CLUB",
        date = "06/07/2024",
        time = "20:30",
        type = "event",
        url = "https://backstage.eu/coldheart-rock-classics.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b532d30",
        name = "FREEDOM CALL - Live 2024",
        description = "Metal",
        venue = "BACKSTAGE HALLE",
        date = "05/09/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/freedom-call-live-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b53406a",
        name = "DORO - Conqueress - Forever Strong And Proud",
        description = "Rock",
        venue = "BACKSTAGE WERK",
        date = "12/22/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/doro-winter-tour-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b5352d6",
        name = "SABBAT & GRUESOME - Live 2024",
        description = "Thrash Metal",
        venue = "BACKSTAGE CLUB",
        date = "07/10/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/sabbat-gruesome-live-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b536adf",
        name = "ACCEPT - HUMANOID TOUR 2024",
        description = "Heavy Metal",
        venue = "BACKSTAGE WERK",
        date = "11/12/2024",
        time = "19:30",
        type = "event",
        url = "https://backstage.eu/accept-humanoid-tour-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b53818e",
        name = "BACKSTAGE HAUSPARTY",
        description = "Party",
        venue = "BACKSTAGE WERKSTATT - STUDIO",
        date = "02/17/2024",
        time = "23:00",
        type = "event",
        url = "https://backstage.eu/backstage-hausparty.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b539615",
        name = "ROLLERDISCO - \u201eDress`n`Dance ' - zu Fasching",
        description = "Rollschuh Disko",
        venue = "Backstage Arena",
        date = "02/13/2024",
        time = "17:00",
        type = "event",
        url = "https://backstage.eu/rollerdisco-dress-n-dance-zu-fasching.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b53a943",
        name = "ALIEN WEAPONRY - EU/UK SUMMER TOUR",
        description = "Groove Metal",
        venue = "BACKSTAGE HALLE",
        date = "06/08/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/alien-weaponry-eu-uk-summer-tour.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b53be2f",
        name = "DONOTS - 30 JAHRE-TOUR: GRAND BIRTHDAY SLAMS | 04.12.24",
        description = "Rock",
        venue = "BACKSTAGE WERK",
        date = "12/04/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/donots-30-jahre-tour-grand-birthday-slam-04-12-24.html",
        pkstatus = "62"
         }, new BackstageEvent {
                id = "65ca06b53d652",
        name = "DONOTS - 30 JAHRE-TOUR: GRAND BIRTHDAY SLAMS | 05.12.24",
        description = "Rock",
        venue = "BACKSTAGE WERK",
        date = "12/05/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/donots-30-jahre-tour-grand-birthday-slam-05-12-24.html",
        pkstatus = "62"
         }, new BackstageEvent {
                id = "65ca06b53e9e3",
        name = "Bonfire Unplugged & Lesung Hans Ziller Biografie",
        description = "Rock",
        venue = "BACKSTAGE CLUB",
        date = "05/28/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/bonfire-unplugged-und-biografie-von-hans-ziller-live-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b53fbcd",
        name = "ELL - Live 2024",
        description = "Rock",
        venue = "BACKSTAGE CLUB",
        date = "12/01/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/ell-live-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b5411e9",
        name = "ICHIKA NITO - Live 2024",
        description = "Rock",
        venue = "BACKSTAGE HALLE",
        date = "05/24/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/ichika-nito-live-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b54258d",
        name = "TOM WALKER - Live 2024",
        description = "Rock",
        venue = "BACKSTAGE WERK",
        date = "11/02/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/tom-walker-live-2024.html",
        pkstatus = "62"
         }, new BackstageEvent {
                id = "65ca06b543c09",
        name = "KNUCKLE HEAD - Live 2024",
        description = "Rock",
        venue = "BACKSTAGE HALLE",
        date = "08/31/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/knuckle-head-live-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b544db1",
        name = "WREST - Bedtimes Rhymes Tour 2024",
        description = "Indie",
        venue = "BACKSTAGE CLUB",
        date = "05/24/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/wrest-bedtimes-rhymes-tour-2024.html",
        pkstatus = "48"
         }, new BackstageEvent {
                id = "65ca06b546139",
        name = "NOGU SVELO! - Live 2024",
        description = "Rock",
        venue = "BACKSTAGE CLUB",
        date = "05/27/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/nogu-svelo-live-2024.html",
        pkstatus = "62"
         }, new BackstageEvent {
                id = "65ca06b547250",
        name = "AFROBEAT DELUXE AFTERSHOW PARTY | 12.02.24",
        description = "Reggae, Dancehall",
        venue = "BACKSTAGE WERK",
        date = "02/12/2024",
        time = "22:30",
        type = "event",
        url = "https://backstage.eu/afrobeat-deluxe-aftershow-party-12-02-24.html",
        pkstatus = "61"
         }, new BackstageEvent {
             id = "65ca06b548344",
        name = "GODSLEEP - EUROPEAN TOUR SPRING | SUMMER 2024",
        description = "Stoner Rock",
        venue = "BACKSTAGE CLUB",
        date = "05/02/2024",
        time = "20:00",
        type = "event",
        url = "https://backstage.eu/godsleep-european-tour-spring-summer-2024.html",
        pkstatus = "48"
         } });
        }

    }
    public class BackstageEvent
    {
        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string venue { get; set; }
        public string date { get; set; }
        public string time { get; set; }
        public string type { get; set; }
        public string url { get; set; }
        public string pkstatus { get; set; }
        public string color { get; set; }
        public string badge { get; set; }
    }
}

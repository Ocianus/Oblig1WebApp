﻿using Model;
using System.Collections.Generic;
namespace BLL
{
    public interface ILogikk
    {
        // Bestilling
        List<Bestilling> alleBestillinger();
        Bestilling hentBestilling(int id);
        bool lagreBestilling(Bestilling innBestilling);
        bool slettBestilling(int id);

        // Avgang
        List<Avgang> alleAvganger();
        Avgang hentAvgang(int id);
        bool endreAvgang(Avgang innAvgang);
        bool lagreAvgang(Avgang innAvgang);
        bool slettAvgang(int id);

        // visAvganger
        List<visAvgang> alleVisAvganger();
        visAvgang hentVisAvgang(int id);
        bool endreVisAvgang(visAvgang innAvgang);
        bool lagreVisAvgang(visAvgang innAvgang);
        bool slettVisAvgang(int id);

        // alleavgangstid
        List<alleavgangstid> alleAlleavgangstid();
        alleavgangstid hentAlleavgangstider(int id);
        bool endreAlleavgangstider(alleavgangstid innAvgang);
        bool lagrealleavgangstid(alleavgangstid innAvgang);
        bool slettalleavgangstid(int id);

        // Betaling
        List<Betaling> alleBetalinger();
        Betaling hentBetaling(int id);
        bool lagreBetaling(Betaling innBetaling);
        bool slettBetaling(int id);

        // Bruker
        List<adminBruker> alleBrukere();
        bool lagreBruker(adminBruker innBruker);
        bool bruker_i_db(adminBruker innBruker);
    }
}
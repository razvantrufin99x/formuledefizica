using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace formuledefizica
{
    public class fizica
    {

        //pag3
        //electrostatica

        //actiunea reciproca a sarcinilor electrice
        //fenomene fundamentale

        //1
        //istoric

        //2
        //electrizarea prin 
        //frecare
        //contact

        //3
        //corpuri
        //bune
        //rele
        //conductoare

        //4
        //interpretarea electronica a electrizarii

        //5
        //recunoasterea starii electrice
        //electroscop

        //6
        //electrizarea prin influenta

        //pag 19
        //legea lui coulomb

        //7
        //legea atractiei si respingerii electrostatice

        //forta de interactiune F
        //formula 1
        // k constanta de mediu
        // m1 , m2 masa sarcinilor
        // r distanta dintre sarcini
        public float F(float k , float m1, float m2, float r)
        {
            return k * ((m1 * m1) / (r * r));
        }
        
        //formula 2
        //epsilon permeabilitatea mediului
        //q1 , q2 sarcinile
        //r distanta dintre sarcini
        public float Fq(float q1, float q2, float epsilon, float r)
        { 
            return ((q1 * q2 ) / (epsilon * (r * r)));
        }

        //semnul fortei de interactiune

        //8
        //constanta dielectrica
        //sistemul CGS de unitati de masura
        public const float CGSepsilon0 = 1.0f;

        //formula 3
        //q1 , q2 sarcinile
        //r distanta dintre sarcini
        public float F0(float q1, float q2, float r)
        {
            return ((q1 * q2) /  (r * r));
        }

        //constanta dielectrica
        //F0 forta de interactiune in vid cand CGSepsilon = 1 in formula 3
        //F forta de interactiune
        //epsilon = ktDielectrica

        public float ktDielectrica(float F0, float F)
        {
            return F0 / F;
        }

        //pag 21
        //tabel permeabilitatea anumitor substante

        public List<grupa> listaDePermeabilitatiSubstante = new List<grupa>();

        public void loadListaPermeabilitateSubstante()
        { 
            listaDePermeabilitatiSubstante.Add(new grupa("solid","parafina","2"));
            listaDePermeabilitatiSubstante.Add(new grupa("solid", "ebonita", "2.7"));
            listaDePermeabilitatiSubstante.Add(new grupa("solid", "sulf", "3.6 - 4.3"));
            listaDePermeabilitatiSubstante.Add(new grupa("solid", "sticla", "5-7"));
            listaDePermeabilitatiSubstante.Add(new grupa("solid", "portelan", "6"));
            listaDePermeabilitatiSubstante.Add(new grupa("solid", "mica", "6"));
            listaDePermeabilitatiSubstante.Add(new grupa("lichid", "petrol", "2"));
            listaDePermeabilitatiSubstante.Add(new grupa("lichid", "ulei de transformator", "2.5"));
            listaDePermeabilitatiSubstante.Add(new grupa("lichid", "anilina", "7.2"));
            listaDePermeabilitatiSubstante.Add(new grupa("lichid", "alcool etilic", "26"));
            listaDePermeabilitatiSubstante.Add(new grupa("lichid", "apa", "81"));
            listaDePermeabilitatiSubstante.Add(new grupa("gaz", "heliu", "1.00007"));
            listaDePermeabilitatiSubstante.Add(new grupa("gaz", "hidrogen", "1.0003"));
            listaDePermeabilitatiSubstante.Add(new grupa("gaz", "aer", "1.0006"));
            listaDePermeabilitatiSubstante.Add(new grupa("gaz", "bioxid de carbon", "1.001"));

        }

        //pag 9
        //unitatea electrostatica de cantitate de electricitate

        //unitatea de masura
        //dyna

        //coulomb
        public static double Coulomb = 3 * 10E9;

        //sarcina electrice
        public static double e = 4.8 * 10E-10;

        //masa electron
        public static double me = 10E-27;

        //numarul de electroni de pe un corp incarcat cu o unitate de electricitate CGS
        // 1 / e
        public static double nre = 2 *10E9;

        public double nrelectronidepeuncorp(double x)
        {
            return x / e;
        }

        //pag23

        //formula 3
        //pentru q1 = q2

        public float q12(float r, float F)
        { 
            return  r * (float)Math.Sqrt(F);
        }

        //forta de respingere
        //F
        //G gravitatea 
        //l lungimea
        //m masa
        //g greutatea

        float Frespingere(float G, float r, float l)
        { 
            return (G*r)/(2 * (float)Math.Sqrt(l*l - (r*r / 4)));
        }

        float Frespingere2(float m, float g, float r, float l)
        { 
            return (m * g * r / ((float)Math.Sqrt(4 * l * l - r*r)));
        }

        //de continuat

        //formula 3.1
        //gravitatea
        //m masa
        //g greutatea
        float G(float m, float g)
        {
            return m * g;
        }

        //pag 24
        //intrebari si recapitulare
        //exercitii

        //pag 25

        //distibutia electricitatii pe conductoare
        //electroscop
        //sfera 
        //conductor ovoidal
        //cilindrul lui faraday
        //plasa lui faraday
        //cusca lui faraday

        //pag 28
        //campul electric
        //11.
        //intenstitatea campului electric

        //formula 4.01
        //forta intensitatii campului electric
        //Q sarcina
        //q sarcina electrica
        //r raza
        //epsilon kt de mediu
        float Fice(float Q, float q, float epsilon, float r)
        { 
            return Q*q/(epsilon*r*r);
        }

        //formula 4
        //E intensitatea campului electric
        //F forta
        //q sarcina electrica

        float E(float F, float q)
        {
            return F / q;
        }

        //formula 5
        //Q sarcina
        //q sarcina electrica
        //epsilon
        //r raza
        //pt q = 1 si E = F
        float E2(float  Q, float epsilon, float r)
        {
            return Q/(epsilon * r * r);
        }

        //formula 5.1
        //E0 in vid
        float E0(float Q, float r)
        {
            return Q/r;
        }

        //formula 6
        //Forta care actioneaza asupra unei sarcini eletrice in camp es.
        //q sarcina electrica
        //E intensitatea campul electric
        float Fq(float q, float E)
        {
            return q * E;
        }

        //12
        //linii de forta in campul electric
        //camp eletric omogen intre doua placi

        //13
        //presiunea electro statica
        //spectrul liniilor de forta
        //scurgeri electrice prin varfuri ascutite
        //morisca electrica

        //pag 34
        //intrebari reacapitulare


        //pag 35
        //potential electric

        //14
        //lucrul mecanic la fortelor electrice

        //formula x
        //Forta ca medie geometrica fmg a doua forte fa , fb
        float FMG(float FA, float FB)
        {
            return (float)Math.Sqrt(FA*FB);
        }

        //formula fmg2
        float fmg3(float Q, float q, float epsilon, float rA, float rB)
        {
            return (Q*q)/(epsilon * rA * rB);
        }

        //formula lucrul mecanic L efectuat de F forta electrica medie intre a si b FA , FB
        float L(float F, float rB, float rA)
        {
            return F*(rB - rA);

        }
        //formula L2
        float L2(float Q, float q, float epsilon, float rA, float rB)
        {
            return ((Q*q)/(epsilon*rA*rB))*(rB - rA);

        }

        //formula L3
        float L3(float Q, float q, float epsilon, float rA, float rB)
        {
            return ((Q*q)/(epsilon))*(1/rA - 1/rB);

        }

        //15
        //potential electric
        //diferenta de potential

        float VA(float L, float q)
        {
            return L/q;
        }

        //formula VA2 din formula L3 pt rB = infinit deoarece 1/rB = 0

        float VA2(float Q,  float epsilon, float rA)
        {
            return Q/(epsilon*rA);

        }

        //formula VB
        float VB(float Q,  float epsilon, float rB)
        {
            return Q/(epsilon*rB);

        }

        //formula 10
        //formula L3 scris diferit

        float L10(float q, float VA, float VB)
        {
            return q*(VA-VB);
        }

        //formula 10.1
        //V

        float V(float Q, float epsilon, float r)
        { 
            return Q / (epsilon/r); 
        }


        //16
        //unitatea de potential
        //va - vb = L / q;
        //volt
        //1 V = 1 J / 1 C

        public static double joule = 10E7 ; //ergi
        public static double volt = 1/(3*10E2) ; //st volt

        float V2(float L, float q)
        {
            return L/q;
        }

        //17
        //electron volt

        //lucru = e * volt
        //eV = Lucrul L
        public static double eV = 1.6 * 10E-12 ; //ergi

        //18
        //suprafete echipotentiale
        //L = 0 = Va - Vb

        //formula potentialul unei suprafete sferice electrizate de raza r

        float Vsf ( float Q, float epsilon, float r)
        {
            return Q/ (epsilon / r);
        }

        //19
        //lucrul mecanic al suprafetelor electrice intre doua surpafete echipotentiale
        //


        //20
        //legatura intre camp si potential
        public static double stVcm = 3 * 10E4 ; // v/m

        //pag 43 exercitii , intrebari recapitulare, probleme


        //pag 46
        //capacitatea electrica

        //21 
        //capacitatea electrica a conductorilor
        //constanta ktQV
        public float ktQV(float Q, float V)
        {
            return Q/V;
        }

        //formula 11
        //capacitatea

        public float C(float Q , float V)
        {
            return Q/V;
        }

        //22
        //capacitatea unui conductor sferic
        public float V22(float Q, float epsilon, float r)
        {
            return Q/ (epsilon/r);
        }

        //capacitatea unui conductor sferic cand epsilon in vid = 1
        public float V22vid(float Q, float r)
        {
            return Q/r;
        }

        //12
        //capacitatea unei sfere 

        public float Csfera(float Q, float r)
        {
            if(Q==0){
                return r;
            }
            else
            {
                return Q/Q/r;
            }
        }

        //23
        //unitati de capacitate
        
        //Farad 
        //1F = 1C/1V
        //1 cm = 1 ues / 1 stV

        public static double farad = 9 * 10E11; //cm

        //1F = 900 miliarde de cm sau 9 milioane km
        //1uF = 9 km
        //1pF = 0.9cm = 9 mm
        //1 cm r = 10/9 pF;

        //pag 49
        //exemplu


        //pag50
        //condensatori electrici

        //24
        //condensarea electricitatii

        //formula pag50
        //masini electrostatice

        public float Q50(float C, float V)
        {
            return C*V;
        }

        //25 condensatori electrici
        //butelia leyda

        //26
        //studiul experimental al condensatorilor

        
        //formula 15
        float C15(float epsilon , float S, float d)
        {
            return (epsilon * S) / (4 * (float)Math.PI * d);
        }

        //27
        //rolul dielectricului la un condensator

        //28
        //diferite tipuri de condensatori
        //hartie
        //ceramici
        //ficsi
        //electrolitici
        //cu mica
        //variabili
        //cu aer


        //29
        //gruparea condensatoarelor

        //formula pag59
        //C paralele
        public float Ci49(float Qi, float VA, float VB)
        {
             return Qi/(VA-VB);
        }

        public float sumaQ(ref float[] Qi)
        {
            float s = 0;
            for(int i = 0 ; i< Qi.Length ; i++)
            {
                s += Qi[i];
            }

            return s;
        }

        //16
        public float sumaC(ref float[] Ci)
        {
            float s = 0;
            for(int i = 0 ; i< Ci.Length ; i++)
            {
                s += Ci[i];
            }

            return s;
        }

        //pag 60
        //intrebari si recapitulare
        //probleme



        //pag 61
        //masini electrostatice

        //30
        //masina els. Wimshurst

        //31
        //scanteia electrica

        //pag63
        //electricitatea atmosferica

        //pag 65
        //intrebari si recapitulare
        //paratraznet
        //traznet
        //tunet
        //fulger

        //pag 66
        //electrocinetica

        //legile curentului electric continuu
        //curentul electric

        //33
        //curentul electric in metale
        //reteaua cristalina a unui metal si gazul electronic
        //deplasarea electronilor liberi
        //conductor incarcat
        //sensul curentului electric

        //34
        //generatorul electric
        //circuit electric
        //circuit hidraulic


        //35
        //fotoelementul
        //elementul volta

        //formula W  = q * u 
        public float W(float q, float U)
        {
            return q * U;
        }

        public float W2(float q, float E)
        {
            return q * E;
        }

        public float E35(float q, float W)
        {
            return W/q;
        }

        //36
        //circuit electric

        //37
        //efectele curentului electric
        //caloric
        //chimic
        //magnetic
        //oersted 
        //regula mainii drepte

        //38
        //sensul curentului electric
        //sensul conventional + to -
        //sensul real + to -
        //simbol geenrator electric cu semne

        //pag 77
        //intrebari recapitulative

        //intensitatea curentului electric

        //39
        //definitie

        //formula 17
        public float I(float q, float t)
        {
            return q / t;
        }

        //40
        //intensitatea curentului electric pe un conductor

        //41
        //unitatea de instensitate

        //1A = s(C/s)

        //amper A
        //ampermetrul

        //pag 80
        //intrebari recapitulative

        //pag 80
        //tensiuena si rezistenta electrica
        //legea lui ohm

        //42 tensiunea electrica si masurarea ei
        //conectarea voltmetrului in paralel
        //conectarea ampermetrului in serie

        //43
        //tensiunea electromotoare tem si tensiunea la borne

        //44
        //tensiunea electrica si potentialul

        //45
        //legea lui ohm

         //formula pag 84
        //rezistenta Rkt sau k
        public float K(float U, float I)
        {
            return U/I;
        }

        // formula curentului I ohm
        public float I45(float U, float R)
        {
            return U/R;
        }

        //reprezentarea grafica a legii lui ohm in d.c.

        //pag 86
        //46
        //rezistenta electrica
        //semne  si simboluri

        //47
        //unitatea de rezistenta
        //R = U/I
        //1 omega Ohm = 1 * (V / A)

        //etalonul ohmului
        //etalon de rezistenta cu fir

        //48
        //dependenta rezistentei de dimensiunile si de natura conductorului

        //rezistenta variaza proportional cu lungimea firului



        //formula R
        //ro rezistenta materialului
        //l lungimea in cm
        //s sectiunea in cm2
        //R variaza invers proportional cu sectiunea
        //formula 21
        public float R(float ro, float l, float s)
        {
            return ro*(l/s);
        }

        //formula ro
        //ohm per cm
         public float ro(float R, float l, float s)
        {
            return (R * s ) / l;
        }

        //conductivitatea
        //inversul ro

         public float cond(float ro)
        {
            return 1/ro;
        }

        //conductanta
        //inversul R
         public float conda(float R)
        {
            return 1/R;
        }

        //pag 90
        //tabel cu coeficientul termic la substantelor si ro
         //de adaugat acest tabel

        //coeficientul termic al substantelor

        //49
        //dependenta rezistentei de temperatura
        //R variaza cu temperatura
        //ro0 ro la 0 grade
        //alfa coef termic de variatiei cu temperatura  pt metale pure
        //aliajele vs metale pure
        //formula 22
          public float e22(float ro0, float alfa, float t)
        {
            return ro0*(1+alfa *t);
        }


        //50
        //leagea lui ohm pentru circuite intregi
        //pag92
        //de continuat

          public float E50(float u, float U)
          {
              return u + U;
          }

         public float u50(float r, float I)
          {
              return r * I;
          }

         public float U50(float R, float I)
          {
              return R*I;
          }

         public float Eb50(float r, float R, float I)
         {
             return (r + R) * I;
         }

         public float Ib50(float E, float R, float I)
         {
             return E*(R + I);
         }

        //51
        //reostate
        //reostat cu cursor
        //reostat cu maneta
        //reostat cu lichid

        //pag 95
        //intrebari recapitulare
        //probleme

        //pag 97
        //legile lui krichhoff
        //aplicatiile legilor tkvc
        //52
        //retele electrice
        //nod de circuit
        //ochi de circuit
        //53
        //legea 1 a lui krichhoff
        //nod
        //suma curentilor este zero

         public float tki(ref float[] a)
         {
             float s = 0;
             for (int i = 0; i < a.Length; i++)
             {
                 s += a[i];
             }
             return s;
         }

        //legea 2 a lui krichhoff
        //ochi
        //suma tensiunilor este zero

         public float tkv(ref float[] a)
         {
             float s = 0;
             for (int i = 0; i < a.Length; i++)
             {
                 s += a[i];
             }
             return s;
         }

        //suma tem

         public float Ek(float Ik, float Rk)
         {
             return Ik * Rk;
         }

         public float E101(float r, float I, float R)
         {
             return I * (r + R);
         }

         public float I101(float pE101, float R, float r)
         {
             return pE101/(R + r);
         }

         //101
        //55
        //legarea in serie si paralele a conductoarelor

        //serie 
        //102

         public float Rserie(float R1, float R2)
         {
             return R1 + R2;
         }

         public float Userie(float U1, float U2)
         {
             return U1 + U2;
         }

         public float Rs(float U, float I)
         {
             return U / I;
         }

         public float Is(float R, float U)
         {
             return U / R;
         }

         public float Us(float R, float I)
         {
             return R * I;
         }

        //paralel
        //103

         public float Ip(float I1, float I2)
         {
             return I1 + I2;
         }

         public float Rp(float R1, float R2)
         {
             float r =  (1 / R1) + (1 / R2);
             return 1 / r;
         }

        //legarea receptoarelor la o retea electrica

        //56
        //scurt circuit

        //57
        //gruparea generatoarelor electrice
        //serie

        public float Igs(float E, float nE, float R, float r, float nR)
        {
            return (nE*E) / (R + (r*nR));
        }
        //paralel

        public float Igp(float E,  float R, float r, float n)
        {
            return  E / (R + (r / n));
        }

        //58
        //suntul
        //pag 108
        //marirea scalei de masura a unui ampermetru

        // I = n * I
        // n * I = Ia + Is
        // (n - 1 )*Ia = Is
        // Is / Ia = n -1
        // Ia* Ra = IS * Rs
        // Is / Ia = Ra / Rs
        // Is/Ia = n - 1 = Ra / Rs
        //Rs = Rn / n -1

        //factorul de amplificare al curentului prin ampermetrul cu sunt

        //l = (Rs * S) / ro

        //pag 110
        //59
        //caderea de tensiuena de-a lungul unui circuit

        public float deltaU(float U1, float U2)
        {
            return U1 - U2;
        }

        //60
        //rezistenta voltmetrului

        public float R1(float R, float Rv)
        { 
            return (R*Rv)/(Rv+R);
        }


        //61
        //potentiometrul
        //reductorul de tensiune
        public float Upot(float ro, float l, float s, float I)
        {
            return ro * (l / s) * I;
        }

        //112
        //intrebari si recapitulare
        //probleme

        //115
        //masurarea rezistentelor
        //62
        //metoda substitutiei

        //63
        //cutia de rezistente

        //64
        //ohmetrul si folosirea lui

        public float Rx(float U1, float U2, float Rv)
        { 
            return ((U1 - U2) / U2 ) * Rv;
        }

        public float U2(float Rv, float I)
        {
            return Rv * I;
        }

        //119
        //energia si putearea curentului electric
        //65
        //energia curentului electric
        //energia este proportionala cu intensitatea
        //W ~ t pt U kt si I kt
        //W ~ I pt U kt si t kt
        //W ~ U pt I kt si t kt


        //k factorul de proportionalitate
        public float W120(float k, float U, float I, float t)
        {
            return k * U * I * t;
        }

        //formula 30
        public float W30(float k, float U, float I, float t)
        {
            return U * I * t; //joules
        }

        //66
        //deducerea formulei energiei electrice

        //L = q * U
        //L = U * I * t
        // L = W

        //formula 31
        public float W31(float R, float I, float t)
        {
            return R * I * I * t;
        }

        //formula 32
        //pt I = U/R
        public float W32(float k, float U, float I, float t)
        {
            return k * U * I * t;
        }

        //67
        //puterea curentului electric
        //formula 33
        public float P(float W, float t)
        {
            return W/t;
        }

        //formula 33b
        public float P1(float U, float I)
        {
            return U * I;
        }

        //formual 34a
        public float P2(float R, float I)
        {
            return R * I * I;
        }
        //formula 34b
        public float P3(float U, float R)
        {
            return U / (R*R);
        }

        //68
        //unitatile de masura pentru energia si puterea curentului electric
        //mks
        //1 w = 1 j/s
        //1 ws = 1 j
        //1 kwh = 10E3 * 3600 s = 3.6 * 10E6 ws
        //1 kwh = 3600000 j
        // 1kwh = 10E3 w
        //1 cp = 736 w  = 75 * 9.81 j/s
        // 1 cp = 0.736 kw
        // 1 kw = 1/36 cp



        //69
        //leaga joule lenz
        //formula 38
        // j = 4.18 joule / cal

        public float W38(float J, float Q)
        {
            return J * Q;
        }

        public float Q38(float J, float W)
        {
            return W / J;
        }

        //a = 1 / j = 1/ 4.18 = 0.238 cal /joule

        //formula 39
        public float Q39(float R, float I, float t)
        {
            return 0.24f * R * I * I * t;
        }

        //formula 40
        public float Q40(float U, float I, float t)
        {
            return 0.24f * U * I * t;
        }

        //formula 41
        public float Q41(float U, float R, float t)
        {
            return 0.24f * ((U*U)/R ) * t;
        }

        //verificarea legii joule lenz

        // cantitatea de caldura degajata de un circuit 
        //Q ~ I*I
        //Q ~ R

        //Q ~ K * R * I * I * t

        public float Q41a(float I)
        {
            return I * I;
        }

        public float Q41b(float R)
        {
            return R;
        }

        public float Q41c(float K, float R, float I, float t)
        {
            return K * R * I * I * t;
        }


        //70
        //aplicatiile efectului termic al curentului electric
        //lampa electrica
        //bec electric
        //filamentul spiralat
        //aparat de incalzit electric
        //siguranta fuzibila

        //tabel valori sugrante
        // S mm2    R ohm/km  suport Imaxim (A)
        //0.5       35          10
        //0.73      23.33       13
        //1         17.50       15
        //1.50      11.67       20
        //2.50      7           27


        //sudura electrica
        //procedeul benardos de sudura elctrica
        //procedeul slavianov
        //sudura prin metoda de contact

        //cuprtor electric cu rezistebnta
        //intrumente de masura
        //ampermetru termic
        //schima ampermetru termic

        //pag 130
        //intrebari si recap
        //probleme


        //pag132
        //de continuat

        //termoelementele si aplicatiilor lor

        //termoelementul
        //experimentul seebeck

        //133
        //tabel proproietati materiale termoelemnt
        //cu sens
        // fier <-- ct 4.2*10E-5 v/grad
        //curpur <-- ct 3.99*10E-5
        //platina --> iradiat 1.22*10E-5
        //argint bismut <-- 7.68*10E-5

        //aplicatii
        //cuplu termoelectric
        //termocuplu
        //pila termo
        //



        //intrebari
        //recap
        //laborator

        //135

        //formula p138
        //echivalent termic A al energiei E
        public float A135(float W, float J)
        {
            return W/J; //1/J
        }

        //circuit pt determinarea echivalentului termic A
        //rezistenta pt determinarea echivalentului termic
        //calorimetru termos

        //pag 139
        //echivalentul termic la lucrului mecanic A
        public float A139(float J)
        {
            return 1 / J;
        }

        //det cu bec electric

        //cantitatea de caldura primita de calorimetru

        // Q = (m + m1) *(fi2-fi1) //cal
        public float Q140( float m ,float m1, float fi1, float fi2)
        {
            return  (m + m1) *(fi2-fi1);
        }

        public float W140(float P, float t2, float t1)
        {
            return P * (t2 - t1); //joule
        }

        public float Pmedie(float pQ140, float pW140)
        {
            return pQ140 / pW140;
        }

        //140
        //curentul electric in electroliti
        //electroliza si legile ei

        //73 
        //disociatia electrolitica
        //conductie in apa distilata si electrolitica

        public float f142(float q1, float q2, floar epsilon, float r)
        {
            return (q1 * q2) / (epsilon * r * r);

        }

        public float f1(float f, float epsilon)
        {
            return f / epsilon;
        }

        //electroliza clorurii de cupru

        //75
        //reactii secundare
        //deplasarea dirijata a electronilor
        //electroliza sulfatului de sodiu
        //electroliza cu anod solubil

        //electroliza niso4

        //76
        //legile electrolizei

        //verificarea primei legi
        //agno3

        //m masa depusa
        public float m148(float I)
        { return I; }


        public float m148b(float t)
        {
            return t;
        }

        //formula 42
        public float m42(float k, float I, float t)
        {
            return k * t * I;
        }

        //formula 43
        //i*t =q
        public float m43(float k, float q)
        {
            return k * q;
        }

        //formula kt proportionala
        public float k149(float m, float I, float t)
        { 
            return m/(I*t);
        }

        //influenta electrolitului
        //A masa atomica 
        // n valenta atomului
        public float mAN(float A, float n)
        {
            return A / n;
        }

        //formula 45
        //k factor proportionalitate cantitativ
        public float mkAN(float k1, float A, float n)
        {
            return k1*( A / n);
        }

        public float maAN2(float lambda , float A, float n, float I, float t)
        {
            return lambda * (A / n) * I * t;
        }

        //formula 48
        //echivalentul electrochimic k = 
        public float k48(float lambda, float A, float n)
        {
            return lambda * (A / n);
        }

        //echivalentul chimic
        public float lambda48(float k, float A, float n)
        {
            return k / (A / n);
        }

        //pagina 151
        //tabel substante echivalent chimic A/n si electrochimic k
        //substanta     A       n       A/n ech chim    k echiv elechim
        //H             1.0     1       1.0             0.01
        //Ag           107.0     1       107.0            1.118         
        //Cl            35.46     1       35.46             0.367
        //O             16.0     2       8.0             0.0829
        //CU            63.3     2       31.65             0.320
        //Ni            58.69     2       29.345            0.3041
        //Al            26.97     3       8.99             0.094



        //de continuat pag 152

        //77
        //numarul lui faraday

























    }
}

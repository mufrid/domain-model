module MembershipTypes

type MineAbonnement = Medlemsblad | Nyhetsbrev

type PersonligInformasjon = PersonligInformasjon of string
type Brukernavn = Brukernavn of string
type Passord = Passord of string
type Sikkerhet = { Brukernavn : Brukernavn; Passord : Passord }
type MinProfil = { PersonligInfo : PersonligInformasjon; Sikkerhetspreferanser : Sikkerhet }

type Faktura = Betalt | Ubetalt
type Betaling = Bank | AvtaleGiro
type Medlem = { Faktura : Faktura; Betaling : Betaling; MineAbonnement : MineAbonnement; MinProfil : MinProfil }






# 🧭 ByGuide – Roskildes Digitale Oplevelsesplatform

### 1. Obligatorisk Opgave – Efterår 2024 
**Fag:** Programmering, Systemudvikling og Projektstyring

ByGuide er en digital platform, som præsenterer Roskilde Kommunes begivenheder, attraktioner og kulturarv i et brugervenligt og mobilvenligt format. Brugere kan læse opslag, finde oplevelser og begivenheder, mens virksomheder og kommune kan tilføje indhold. Projektet er udviklet i Razor Pages med fokus på funktionalitet frem for design.

## 🧩 Funktionalitet

Platformen tilbyder følgende funktioner:

### 🏛️ Offentligt indhold
- Læs historiske opslag og artikler fra Roskilde Kommune
- Gennemse attraktioner og oplevelser
- Se og filtrér begivenheder efter kategori og dato
- Turistinformation og billeder for besøgende

### 🧑‍💼 Virksomheder
- Anmodning om konto
- Opret og redigér egne begivenheder og oplevelser
- Indhold godkendes af administrator

### 🛠️ Administrator
- Godkend nye virksomheder
- Godkend/redigér indhold fra virksomheder
- Opret egne opslag (kun kommune)

## 🛠️ Teknologi-stack

| Lag        | Teknologi                |
|------------|--------------------------|
| Frontend   | HTML, CSS, JavaScript    |
| Backend    | ASP.NET Core Razor Pages |
| Data       | JSON-filer (ingen database) |
| Hosting    | Lokalt/FTP               |
| Versionsstyring | GitHub              |

## 🗄️ Datamodel

Applikationen bruger følgende objekter, gemt som JSON:

- `Company`: Virksomheder med login og metadata
- `Event`: Begivenheder med titel, beskrivelse, sted og tidspunkt
- `Experience`: Oplevelser (f.eks. museer)
- `Post`: Kommuneopslag (artikler mv.)
- `TouristInfo`: Sektion med tekst og billeder

Relationer håndteres manuelt via ID’er i JSON-strukturer.

## 🧾 Roller

| Rolle         | Rettigheder                                          |
|---------------|------------------------------------------------------|
| Offentlig     | Læse alt offentlig indhold                           |
| Virksomhed    | Redigere egne events og oplevelser (efter godkendelse) |
| KommuneAdmin  | Redigere alt, godkende virksomheder og opslag        |

## ✅ Implementeret i kode

- JSON-filbaseret datalagring med helperklasser (`OpeningHoursHelper`, `UniqueIdGenerator`)
- Razor Pages med `OnGet`, `OnPost` og binding
- CRUD på `Post`, `Event`, `Experience`, `TouristInfo`
- Rollespecifik adgang i UI
- Dynamisk listegenerering på forsiden (til dels)
- Responsive tilpasninger (delvist)

## ⚠️ Begrænsninger

- Ingen database eller login-system (simuleret)
- Forsiden er ikke færdiggjort
- Design er placeholder-orienteret og ikke mobiloptimeret
- Mangler fuld sammenkobling mellem lister og visninger

## 🏗️ Videreudviklingsforslag

- Implementering af rigtig login- og rolesystem
- Flytning af data til database
- Bedre visuel præsentation og mobilvenligt design
- Interaktivt kort over events og attraktioner
- Mulighed for social deling og sprogskifte (da/en)
- Automatisk e-mail ved virksomhedsanmodninger

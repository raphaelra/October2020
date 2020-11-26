EXTERNAL place_actor(left_actor_name, right_actor_name)
EXTERNAL change_emotion(emotion,ID)
//Left = 0, Right = 1
{place_actor("Actor","Actor 1")}
{change_emotion("Angry",0)}
{change_emotion("Happy",1)}

LIST animalF = (abelha), (raposa), (lebre), (cobra), (andorinha), (gralha), (mosca), (serpente), (cigarra), (galinha), (tartaruga), (formiga),(ovelha)

LIST animalM = (javali), (corvo), (elefante), (cachorro), (gato), (rato), (galo), (lobo), (crocodilo), (porco)

LIST local = (clareira) 

->Fabula

=== Fabula ===

Certa vez,
Disputavam entre si 

{~ Um {LIST_RANDOM(animalM)} caminhava em companhia de um {LIST_RANDOM(animalM)}.->MM1|Um {LIST_RANDOM(animalM)} caminhava em companhia de uma {LIST_RANDOM(animalF)}.->MF1|Uma {LIST_RANDOM(animalF)} caminhava em companhia de um {LIST_RANDOM(animalM)}.->FM1|Uma {LIST_RANDOM(animalF)} caminhava em companhia de uma {LIST_RANDOM(animalF)}.->FF1}
  * uesfhiudhr ->FM1
  *eger wr g ->FM1


=MM1
 . E cada um, por sua vez, ia alardeando suas façanhas. No caminho, porém, havia uma estela de pedra com a representação de um {LIST_RANDOM(animalM)} esganando um {LIST_RANDOM(animalM)}.
  "Está vendo como somos superiores a vocês?", disse a {LIST_RANDOM(animalM)} ao {LIST_RANDOM(animalM)}, apontando-a. E a {LIST_RANDOM(animalM)}, disfarçando um sorisso , retrucou: se uma {LIST_RANDOM(animalM)} soubesse esculpir, você veria muitas {LIST_RANDOM(animalM)} sob as {~patas|garras} de {LIST_RANDOM(animalM)}.
    * uesfhiudhr ->FM1
  *eger wr g ->FM1
->DONE
=MF1
 E cada um, por sua vez, ia alardeando suas façanhas. No caminho, porém, havia uma estela de pedra com a representação de um {LIST_RANDOM(animalM)} esganando uma {LIST_RANDOM(animalF)}.
  "Está vendo como somos superiores a vocês?", disse a {LIST_RANDOM(animalF)} à {LIST_RANDOM(animalF)}, apontando-a. E a {LIST_RANDOM(animalF)}, disfarçando um sorisso , retrucou: se uma {LIST_RANDOM(animalF)} soubesse esculpir, você veria muitas {LIST_RANDOM(animalF)} sob as {~patas|garras} de {LIST_RANDOM(animalF)}.
  * uesfhiudhr ->FM1
  *eger wr g ->FM1
->DONE
=FM1
 E cada um, por sua vez, ia alardeando suas façanhas. No caminho, porém, havia uma estela de pedra com a representação de um {LIST_RANDOM(animalF)} esganando um {LIST_RANDOM(animalM)}.
  "Está vendo como somos superiores a vocês?", disse a {LIST_RANDOM(animalF)} à {LIST_RANDOM(animalF)}, apontando-a. E a {LIST_RANDOM(animalF)}, disfarçando um sorisso , retrucou: se uma {LIST_RANDOM(animalF)} soubesse esculpir, você veria muitas {LIST_RANDOM(animalF)} sob as {~patas|garras} de {LIST_RANDOM(animalF)}.
->DONE
=FF1
 E cada uma, por sua vez, ia alardeando suas façanhas.
 No caminho, porém, havia uma estela de pedra com a representação de um {LIST_RANDOM(animalF)} esganando um {LIST_RANDOM(animalF)}.
 "Está vendo como somos superiores a vocês?", disse a {LIST_RANDOM(animalF)} à {LIST_RANDOM(animalF)}, apontando-a. E a {LIST_RANDOM(animalF)}, disfarçando um sorisso , retrucou: se uma {LIST_RANDOM(animalF)} soubesse esculpir, você veria muitas {LIST_RANDOM(animalF)} sob as {~patas|garras} de {LIST_RANDOM(animalF)}.
 
->DONE


{~Certa vez, {~um {~leão|burro|galo|lobo}|uma {~raposa|abelha|lebre|águia}} e {~um {~leão|burro|galo|lobo}|uma {~raposa|abelha|lebre|águia}} (ACAO).|(OUTROINICIO).}  
Certo dia eu sonhei que eu era



{~I {~once|} dreamt I was a fish.|I {~once|} had a dream I was a fish.}
I was one of many {~others|} who, in unison, swam to the beat of an insatiable appetite. We yearned for nothing more  than to graze on the swarms of summer plankton that bloomed not far from where we found ourselves. Focused only on the hunger that propelled us towards our common goal. 
Drifting shadows gathered overhead, eclipsing the colors of the evening sun as it set on our skin but never truly clouding its radiance. We paid the shadows no mind until they grew too large to ignore. They became so large that they began to fall out of the sky, diving straight for us. They descended and shot right back up again with some of us in tow.
The talons, beaks and flapping wings that stirred the frothing water above us disrupted the synchronicity of the collective and we were soon spread out in all directions.
In the midst of the commotion I was left alone with a decision that was mine and mine alone to make. Fish were being picked off to my left and fish were being picked off to my right. I was forced to act and to do it fast.

-> FishDreamAction

= FishDreamAction
*	(left) [I went left] -> FishDreamActionResult
* 	(right) [I went right] -> FishDreamActionResult

= FishDreamActionResult
I {~swerved to the |darted to the |took a }{left:left|{right:right}}{~{~, dodging |, avoiding |, evading }{~the sharp talons | the crooked beak | the diving shadow }that came from above->FishAlive| but it {was {~ an ineffective maneuver| of no use| meaningless| pointless| hopeless}|didn’t matter}. {~ The sharp talons | The crooked beak | The diving shadow }{~hooked me in between the ribs |pierced my eye |clutched me by the gill |got me by the tail }and {~lifted |pulled |hoisted } my body out of the water.->FishDead}

=FishDead
{~The pain was excruciating.|I had never known such pain.} 
I shook violently in an attempt to set myself free but the winged apparition had gripped me too tightly. My struggle had succeeded only in widening the injury, making it spew more and more blood.
Although I could not breathe or see clearly, I knew I was headed towards my death. The shadow took me higher and higher and higher still. I stopped struggling for a moment and, despite my faltering sight, noticed that the glow of the sun that sat on the scales below me never dimmed, no matter how high I went. The reflections on their skins danced in the light of the afternoon.
In my last moments I could think only of my hunger, hoping that those who survived the {~carnage|slaughter} would reach the swarms of summer plankton that bloomed not far from where they found themselves. I hoped they would have their fill so that the efforts of those like me would not be for naught.
->DONE

= FishAlive
and {~masterfully|skillfully} {~maneuvering|weaving} myself through the agitated masses.
The winged figure {~dived ever deeper|plunged itself} into the waters after me, showing no sign of {~desistance|giving up} in its {~pursuit|chase}. After its first failed attempt, the shadow {~found its way back|propelled itself back up} to the sky only to {~{~swoop|come crashing} down|descend|} once more. The {{~{~barrage|onslaught} of}|} assaults continued but I eluded them all, one by one, with {~expertise|prowess} until I was as far away from the {~carnage|chaos|confusion} as possible.
I had managed to {~escape|slip my way out of} a massacre yet I knew I would not be so lucky next time. In my weariness, the beat of hunger called to me again, stronger than before, and I looked around to see if there were survivors that, like me, yearned for nothing more than to graze on the swarms of summer plankton that bloomed not far from where we found ourselves. It drove us to reunite and move forward towards our common goal that hid itself somewhere in the wide waters that stretched ahead of us. We held on to that idea but it did nothing to appease our hunger.

->FishEat

= FishEat
and then, in that same moment, I was a bird soaring over an open sea...
//capelin iceshelf plankton feeding

//'s when we spotted it. The crystalline in the northernmost reaches of th
->DONE


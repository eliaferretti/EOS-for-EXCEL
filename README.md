Elia Ferretti © 2022

(english below)

Il componente aggiuntivo contiene le seguenti funzioni:

!!TUTTE LE VARIABILI VANNO FORNITE (E VENGONO RESTITUITE) NELLE UNITA' DEL SISTEMA INTERNAZIONALE!!

1) zeta_VdW:		funzione che restituisce il fattore di comprimibilità [-] previsto dall’equazione cubica VdW di un composto puro a partire dai valori Tc,pc,T,pressure,state dove:
					Tc 			[K] è la temperatura critica del composto puro,
					pc 			[Pa] è la pressione critica del composto puro,
					T 			[K] è la temperatura,
					pressure 	[Pa] è la pressione,
					state 		[-] è una stringa rappresentante la fase del composto ("V" o "L").
				
2) zeta_RK:			funzione che restituisce il fattore di comprimibilità [-] previsto dall’equazione cubica RK di un composto puro a partire dai valori Tc,pc,T,pressure,state dove:
					Tc 			[K] è la temperatura critica del composto puro,
					pc 			[Pa] è la pressione critica del composto puro,
					T 			[K] è la temperatura,
					pressure 	[Pa] è la pressione,
					state 		[-] è una stringa rappresentante la fase del composto ("V" o "L").		
				
3) zeta_RKS:		funzione che restituisce il fattore di comprimibilità [-] previsto dall’equazione cubica RKS di un composto puro a partire dai valori Tc,pc,w,T,pressure,state dove:
					Tc 			[K] è la temperatura critica del composto puro,
					pc 			[Pa] è la pressione critica del composto puro,
					w 			[-] è il fattore acentrico di Pitzer del composto puro,
					T 			[K] è la temperatura,
					pressure 	[Pa] è la pressione,
					state 		[-] è una stringa rappresentante la fase del composto ("V" o "L").
				
4) zeta_PR:			funzione che restituisce il fattore di comprimibilità [-] previsto dall’equazione cubica PR di un composto puro a partire dai valori Tc,pc,w,T,pressure,state dove:
					Tc 			[K] è la temperatura critica del composto puro,
					pc 			[Pa] è la pressione critica del composto puro,
					w 			[-] è il fattore acentrico di Pitzer del composto puro,
					T 			[K] è la temperatura,
					pressure 	[Pa] è la pressione,
					state 		[-] è una stringa rappresentante la fase del composto ("V" o "L").

5) phi_VdW:			funzione che restituisce il coefficiente di fugacità [-] previsto dall’equazione cubica VdW di un composto puro a partire dai valori Tc,pc,T,pressure,state dove:
					Tc 			[K] è la temperatura critica del composto puro,
					pc 			[Pa] è la pressione critica del composto puro,
					T 			[K] è la temperatura,
					pressure 	[Pa] è la pressione,
					state 		[-] è una stringa rappresentante la fase del composto ("V" o "L").
				
6) phi_RK:			funzione che restituisce il coefficiente di fugacità [-] previsto dall’equazione cubica RK di un composto puro a partire dai valori Tc,pc,T,pressure,state dove:
					Tc 			[K] è la temperatura critica del composto puro,
					pc 			[Pa] è la pressione critica del composto puro,
					T 			[K] è la temperatura,
					pressure 	[Pa] è la pressione,
					state 		[-] è una stringa rappresentante la fase del composto ("V" o "L").	
				
7) phi_RKS:			funzione che restituisce il coefficiente di fugacità [-] previsto dall’equazione cubica RKS di un composto puro a partire dai valori Tc,pc,w,T,pressure,state dove:
					Tc 			[K] è la temperatura critica del composto puro,
					pc 			[Pa] è la pressione critica del composto puro,
					w 			[-] è il fattore acentrico di Pitzer del composto puro,
					T 			[K] è la temperatura,
					pressure 	[Pa] è la pressione,
					state 		[-] è una stringa rappresentante la fase del composto ("V" o "L").
				
8) phi_PR:			funzione che restituisce il coefficiente di fugacità [-] previsto dall’equazione cubica PR di un composto puro a partire dai valori Tc,pc,w,T,pressure,state dove:
					Tc 			[K] è la temperatura critica del composto puro,
					pc 			[Pa] è la pressione critica del composto puro,
					w 			[-] è il fattore acentrico di Pitzer del composto puro,
					T 			[K] è la temperatura,
					pressure 	[Pa] è la pressione,
					state 		[-] è una stringa rappresentante la fase del composto ("V" o "L").

9) hR_VdW:			funzione che restituisce l' entalpia residua [J/mol] prevista dall’equazione cubica VdW di un composto puro a partire dai valori Tc,pc,T,pressure,state dove:
					Tc 			[K] è la temperatura critica del composto puro,
					pc 			[Pa] è la pressione critica del composto puro,
					T 			[K] è la temperatura,
					pressure 	[Pa] è la pressione,
					state 		[-] è una stringa rappresentante la fase del composto ("V" o "L").
				
10) hR_RK:			funzione che restituisce l' entalpia residua [J/mol] prevista dall’equazione cubica RK di un composto puro a partire dai valori Tc,pc,T,pressure,state dove:
					Tc 			[K] è la temperatura critica del composto puro,
					pc 			[Pa] è la pressione critica del composto puro,
					T 			[K] è la temperatura,
					pressure 	[Pa] è la pressione,
					state 		[-] è una stringa rappresentante la fase del composto ("V" o "L").		
				
11) hR_RKS:			funzione che restituisce l' entalpia residua [J/mol] prevista dall’equazione cubica RKS di un composto puro a partire dai valori Tc,pc,w,T,pressure,state dove:
					Tc 			[K] è la temperatura critica del composto puro,
					pc 			[Pa] è la pressione critica del composto puro,
					w 			[-] è il fattore acentrico di Pitzer del composto puro,
					T 			[K] è la temperatura,
					pressure 	[Pa] è la pressione,
					state 		[-] è una stringa rappresentante la fase del composto ("V" o "L").
					
12) hR_PR:			funzione che restituisce l' entalpia residua [J/mol] prevista dall’equazione cubica PR di un composto puro a partire dai valori Tc,pc,w,T,pressure,state dove:
					Tc 			[K] è la temperatura critica del composto puro,
					pc 			[Pa] è la pressione critica del composto puro,
					w 			[-] è il fattore acentrico di Pitzer del composto puro,
					T 			[K] è la temperatura,
					pressure 	[Pa] è la pressione,
					state 		[-] è una stringa rappresentante la fase del composto ("V" o "L").

13) zeta_VdWmix:	funzione che restituisce il fattore di comprimibilità [-] previsto dall’equazione cubica VdW di un composto puro a partire dai valori x,NC,Tc,pc,T,pressure,state dove:
					x		[-] è il vettore delle composizioni,
					NC		[-] è il numero di componenti (dimensione del vettore x),
					Tc 		[K] è il vettore delle temperature critiche dei composti puri,
					pc 		[Pa] è il vettore delle pressioni critiche dei composti puri,
					T 		[K] è la temperatura,
					p 		[Pa] è la pressione,
					state 	[-] è una stringa rappresentante la fase della miscela ("V" o "L").
				
14) zeta_RKmix:		funzione che restituisce il fattore di comprimibilità [-] previsto dall’equazione cubica RK di un composto puro a partire dai valori x,NC,Tc,pc,T,pressure,state dove:
					x		[-] è il vettore delle composizioni,
					NC		[-] è il numero di componenti (dimensione del vettore x),
					Tc 		[K] è il vettore delle temperature critiche dei composti puri,
					pc 		[Pa] è il vettore delle pressioni critiche dei composti puri,
					T 		[K] è la temperatura,
					p 		[Pa] è la pressione,
					state 	[-] è una stringa rappresentante la fase della miscela ("V" o "L").
					
15) zeta_RKSmix:	funzione che restituisce il fattore di comprimibilità [-] previsto dall’equazione cubica RKS di un composto puro a partire dai valori x,NC,Tc,pc,w,T,pressure,state dove:
					x		[-] è il vettore delle composizioni,
					NC		[-] è il numero di componenti (dimensione del vettore x),
					Tc 		[K] è il vettore delle temperature critiche dei composti puri,
					pc 		[Pa] è il vettore delle pressioni critiche dei composti puri,
					w 		[-] è il vettore dei fattori acentrici di Pitzer dei composti puri,
					T 		[K] è la temperatura,
					p 		[Pa] è la pressione,
					state 	[-] è una stringa rappresentante la fase della miscela ("V" o "L").	
					
16) zeta_PRmix:		funzione che restituisce il fattore di comprimibilità [-] previsto dall’equazione cubica PR di un composto puro a partire dai valori x,NC,Tc,pc,w,T,pressure,state dove:
					x		[-] è il vettore delle composizioni,
					NC		[-] è il numero di componenti (dimensione del vettore x),
					Tc 		[K] è il vettore delle temperature critiche dei composti puri,
					pc 		[Pa] è il vettore delle pressioni critiche dei composti puri,
					w 		[-] è il vettore dei fattori acentrici di Pitzer dei composti puri,
					T 		[K] è la temperatura,
					p 		[Pa] è la pressione,
					state 	[-] è una stringa rappresentante la fase della miscela ("V" o "L").

17) phi_VdWmix:		funzione che restituisce il coefficiente di fugacità [-] previsto dall’equazione cubica VdW di un composto puro a partire dai valori index,x,NC,Tc,pc,T,pressure,state dove:
					index   [-] è l'indice della specie di interesse (indice rispetto a uno dei seguenti vettori, dev'essere un numero tra 1 e NC),
					x		[-] è il vettore delle composizioni,
					NC		[-] è il numero di componenti (dimensione del vettore x),
					Tc 		[K] è il vettore delle temperature critiche dei composti puri,
					pc 		[Pa] è il vettore delle pressioni critiche dei composti puri,
					T 		[K] è la temperatura,
					p 		[Pa] è la pressione,
					state 	[-] è una stringa rappresentante la fase della miscela ("V" o "L").
				
18) phi_RKmix:		funzione che restituisce il coefficiente di fugacità [-] previsto dall’equazione cubica RK di un composto puro a partire dai valori index,x,NC,Tc,pc,T,pressure,state dove:
					index   [-] è l'indice della specie di interesse (indice rispetto a uno dei seguenti vettori, dev'essere un numero tra 1 e NC),
					x		[-] è il vettore delle composizioni,
					NC		[-] è il numero di componenti (dimensione del vettore x),
					Tc 		[K] è il vettore delle temperature critiche dei composti puri,
					pc 		[Pa] è il vettore delle pressioni critiche dei composti puri,
					T 		[K] è la temperatura,
					p 		[Pa] è la pressione,
					state 	[-] è una stringa rappresentante la fase della miscela ("V" o "L").	
					
19) phi_RKSmix:		funzione che restituisce il coefficiente di fugacità [-] previsto dall’equazione cubica RKS di un composto puro a partire dai valori index,x,NC,Tc,pc,w,T,pressure,state dove:
					index   [-] è l'indice della specie di interesse (indice rispetto a uno dei seguenti vettori, dev'essere un numero tra 1 e NC),
					x		[-] è il vettore delle composizioni,
					NC		[-] è il numero di componenti (dimensione del vettore x),
					Tc 		[K] è il vettore delle temperature critiche dei composti puri,
					pc 		[Pa] è il vettore delle pressioni critiche dei composti puri,
					T 		[K] è la temperatura,
					p 		[Pa] è la pressione,
					state 	[-] è una stringa rappresentante la fase della miscela ("V" o "L").
				
20) phi_PRmix:		funzione che restituisce il coefficiente di fugacità [-] previsto dall’equazione cubica PR di un composto puro a partire dai valori index,x,NC,Tc,pc,w,T,pressure,state dove:
					index   [-] è l'indice della specie di interesse (indice rispetto a uno dei seguenti vettori, dev'essere un numero tra 1 e NC),
					x		[-] è il vettore delle composizioni,
					NC		[-] è il numero di componenti (dimensione del vettore x),
					Tc 		[K] è il vettore delle temperature critiche dei composti puri,
					pc 		[Pa] è il vettore delle pressioni critiche dei composti puri,
					T 		[K] è la temperatura,
					p 		[Pa] è la pressione,
					state 	[-] è una stringa rappresentante la fase della miscela ("V" o "L").

21) hR_VdWmix:		funzione che restituisce l' entalpia residua [J/mol] prevista dall’equazione cubica VdW di un composto puro a partire dai valori x,NC,Tc,pc,T,pressure,state dove:
					x		[-] è il vettore delle composizioni,
					NC		[-] è il numero di componenti (dimensione del vettore x),
					Tc 		[K] è il vettore delle temperature critiche dei composti puri,
					pc 		[Pa] è il vettore delle pressioni critiche dei composti puri,
					T 		[K] è la temperatura,
					p 		[Pa] è la pressione,
					state 	[-] è una stringa rappresentante la fase della miscela ("V" o "L").	
				
22) hR_RKmix:		funzione che restituisce l' entalpia residua [J/mol] prevista dall’equazione cubica RK di un composto puro a partire dai valori x,NC,Tc,pc,T,pressure,state dove:
					x		[-] è il vettore delle composizioni,
					NC		[-] è il numero di componenti (dimensione del vettore x),
					Tc 		[K] è il vettore delle temperature critiche dei composti puri,
					pc 		[Pa] è il vettore delle pressioni critiche dei composti puri,
					T 		[K] è la temperatura,
					p 		[Pa] è la pressione,
					state 	[-] è una stringa rappresentante la fase della miscela ("V" o "L").
				
23) hR_RKSmix:		funzione che restituisce l' entalpia residua [J/mol] prevista dall’equazione cubica RKS di un composto puro a partire dai valori x,NC,Tc,pc,w,T,pressure,state dove:
					x		[-] è il vettore delle composizioni,
					NC		[-] è il numero di componenti (dimensione del vettore x),
					Tc 		[K] è il vettore delle temperature critiche dei composti puri,
					pc 		[Pa] è il vettore delle pressioni critiche dei composti puri,
					w 		[-] è il vettore dei fattori acentrici di Pitzer dei composti puri,
					T 		[K] è la temperatura,
					p 		[Pa] è la pressione,
					state 	[-] è una stringa rappresentante la fase della miscela ("V" o "L").	
				
24) hR_PRmix:		funzione che restituisce l' entalpia residua [J/mol] prevista dall’equazione cubica PR di un composto puro a partire dai valori x,NC,Tc,pc,w,T,pressure,state dove:
					x		[-] è il vettore delle composizioni,
					NC		[-] è il numero di componenti (dimensione del vettore x),
					Tc 		[K] è il vettore delle temperature critiche dei composti puri,
					pc 		[Pa] è il vettore delle pressioni critiche dei composti puri,
					w 		[-] è il vettore dei fattori acentrici di Pitzer dei composti puri,
					T 		[K] è la temperatura,
					p 		[Pa] è la pressione,
					state 	[-] è una stringa rappresentante la fase della miscela ("V" o "L").


Supporta il lavoro:  https://paypal.me/eliaferretti .
Per qualsiasi problema o bug si contatti lo sviluppatore all'indirizzo: eliaferretti@outlook.it

------------------------------------------------------------------------------------
ENGLISH VERSION
------------------------------------------------------------------------------------

Elia Ferretti © 2022

The add-on contains the following functions:

!!!ALL VARIABLES MUST BE SUPPLIED (AND ARE RETURNED) IN THE UNITS OF THE IN TERNATIONAL SYSTEM!!!

1) zeta_VdW: 	function that returns the compressibility factor [-], predicted by the VdW cubic equation, of a pure compound from the values Tc,pc,T,pressure,state where:
				Tc [K] is the critical temperature of the pure compound,
				pc [Pa] is the critical pressure of the pure compound, 
			    T [K] is the temperature,
				pressure [Pa] is pressure,
				state [-] is a string representing the phase of the compound ('V' or 'L').
				
2) zeta_RK: 	function that returns the compressibility factor [-], predicted by the RK cubic equation, of a pure compound from the values Tc,pc,T,pressure,state where:
				Tc [K] is the critical temperature of the pure compound,
				pc [Pa] is the critical pressure of the pure compound,
				T [K] is the temperature,
				pressure [Pa] is pressure,
				state [-] is a string representing the phase of the compound ('V' or 'L').
				
3) zeta_RKS: 	function that returns the compressibility factor [-], predicted by the RKS cubic equation, of a pure compound from the values Tc,pc,w,T,pressure,state where:
				Tc [K] is the critical temperature of the pure compound,
				pc [Pa] is the critical pressure of the pure compound,
				w [-] is the acentric Pitzer factor of the pure compound,
				T [K] is the temperature,
				pressure [Pa] is pressure,
				state [-] is a string representing the phase of the compound ('V' or 'L').
				
4) zeta_PR: 	function that returns the compressibility factor [-], predicted by the PR cubic equation, of a pure compound from the values Tc,pc,w,T,pressure,state where:
				Tc [K] is the critical temperature of the pure compound,
				pc [Pa] is the critical pressure of the pure compound,
				w [-] is the acentric Pitzer factor of the pure compound,
				T [K] is the temperature,
				pressure [Pa] is pressure,
				state [-] is a string representing the phase of the compound ('V' or 'L').
				
5) phi_VdW: 	function that returns the fugacity coefficient [-], predicted by the VdW cubic equation, of a pure compound from the values Tc,pc,T,pressure,state where:
				Tc [K] is the critical temperature of the pure compound,
				pc [Pa] is the critical pressure of the pure compound,
				T [K] is the temperature,
				pressure [Pa] is pressure,
				state [-] is a string representing the phase of the compound ('V' or 'L').
				
6) phi_RK: 		function that returns the fugacity coefficient [-], predicted by the RK cubic equation, of a pure compound from the values Tc,pc,T,pressure,state where:
				Tc [K] is the critical temperature of the pure compound,
				pc [Pa] is the critical pressure of the pure compound,
				T [K] is the temperature,
				pressure [Pa] is pressure,
				state [-] is a string representing the phase of the compound ('V' or 'L').
				
7) phi_RKS: 	function that returns the fugacity coefficient [-], predicted by the RKS cubic equation, of a pure compound from the values Tc,pc,w,T,pressure,state where:
				Tc [K] is the critical temperature of the pure compound,
				pc [Pa] is the critical pressure of the pure compound,
				w [-] is the acentric Pitzer factor of the pure compound,
				T [K] is the temperature,
				pressure [Pa] is pressure,
				state [-] is a string representing the phase of the compound ('V' or 'L').
				
8) phi_PR: 		function that returns the fugacity coefficient [-], predicted by the PR cubic equation, of a pure compound from the values Tc,pc,w,T,pressure,state where:
				Tc [K] is the critical temperature of the pure compound,
				pc [Pa] is the critical pressure of the pure compound,
				w [-] is the acentric Pitzer factor of the pure compound,
				T [K] is the temperature,
				pressure [Pa] is pressure,
				state [-] is a string representing the phase of the compound ('V' or 'L').
				
9) hR_VdW: 		function that returns the residual enthalpy [J/mol], predicted by the VdW cubic equation, of a pure compound from the values Tc,pc,T,pressure,state where:
				Tc [K] is the critical temperature of the pure compound,
				pc [Pa] is the critical pressure of the pure compound,
				T [K] is the temperature,
				pressure [Pa] is pressure,
				state [-] is a string representing the phase of the compound ('V' or 'L').
				
10) hR_RK: 		function that returns the residual enthalpy [J/mol], predicted by the RK cubic equation, of a pure compound from the values Tc,pc,T,pressure,state where:
				Tc [K] is the critical temperature of the pure compound,
				pc [Pa] is the critical pressure of the pure compound,
				T [K] is the temperature,
				pressure [Pa] is pressure,
				state [-] is a string representing the phase of the compound ('V' or 'L').
				
11) hR_RKS: 	function that returns the residual enthalpy [J/mol], predicted by the RKS cubic equation, of a pure compound from the values Tc,pc,w,T,pressure,state where:
				Tc [K] is the critical temperature of the pure compound,
				pc [Pa] is the critical pressure of the pure compound,
				w [-] is the acentric Pitzer factor of the pure compound,
				T [K] is the temperature,
				pressure [Pa] is pressure,
				state [-] is a string representing the phase of the compound ('V' or 'L').
			
12) hR_PR: 		function that returns the residual enthalpy [J/mol], predicted by the PR cubic equation, of a p compound from the values Tc,pc,w,T,pressure,state where:
				Tc [K] is the critical temperature of the pure compound,
				pc [Pa] is the critical pressure of the pure compound,
				w [-] is the acentric Pitzer factor of the pure compound,
				T [K] is the temperature,
				pressure [Pa] is pressure,
				state [-] is a string representing the phase of the compound ('V' or 'L').
				
13) zeta_VdWmix:	function that returns the compressibility factor [-], provided by the VdW cubic equation, of a mixture from the values x,NC,Tc,pc,T,pressure,state where:
					x [-] is the vector of compositions,
					NC [-] is the number of components (size of vector x),
					Tc [K] is the vector of critical temperatures of pure compounds,
					pc [Pa] is the vector of critical pressures of pure compounds,
					T [K] is the temperature,
					p [Pa] is the pressure,
					state [-] is a string representing the phase of the mixture ('V' or 'L').
					
14) zeta_RKmix: 	function that returns the compressibility factor [-], provided by the RK cubic equation, of a mixture from the values x,NC,Tc,pc,T,pressure,state where:
					x [-] is the vector of compositions,
					NC [-] is the number of components (size of vector x),
					Tc [K] is the vector of critical temperatures of pure compounds,
					pc [Pa] is the vector of critical pressures of pure compounds,
					T [K] is the temperature,
					p [Pa] is the pressure,
					state [-] is a string representing the phase of the mixture ('V' or 'L').
					
15) zeta_RKSmix: 	function that returns the compressibility factor [-], predicted by the RKS cubic equation, of a mixture from the values x,NC,Tc,pc,w,T,pressure,state where:
					x [-] is the vector of compositions,
					NC [-] is the number of components (size of vector x),
					Tc [K] is the vector of critical temperatures of pure compounds,
					pc [Pa] is the vector of critical pressures of pure compounds,
					w [-] is the vector of acentric Pitzer factors of pure compounds,
					T [K] is the temperature,
					p [Pa] is the pressure,
					state [-] is a string representing the phase of the mixture ('V' or 'L').
					
16) zeta_PRmix: 	function that returns the compressibility factor [-], provided by the PR cubic equation, of a mixture from the values x,NC,Tc,pc,w,T,pressure,state where:
					x [-] is the vector of compositions,
					NC [-] is the number of components (size of vector x),
					Tc [K] is the vector of critical temperatures of pure compounds,
					pc [Pa] is the vector of critical pressures of pure compounds,
					w [-] is the vector of acentric Pitzer factors of pure compounds,
					T [K] is the temperature,
					p [Pa] is the pressure,
					state [-] is a string representing the phase of the mixture ('V' or 'L').
					
17) phi_VdWmix: 	function that returns the fugacity coefficient [-], predicted by the VdW cubic equation, of a compound in a mixture from the values index,x,NC,Tc,pc,T,pressure,state where:
					index [-] is the index of the species of interest (index against one of the following vectors, must be a number between 1 and NC),
					x [-] is the vector of compositions,
					NC [-] is the number of components (size of vector x),
					Tc [K] is the vector of critical temperatures of pure compounds,
					pc [Pa] is the vector of critical pressures of pure compounds,
					T [K] is the temperature,
					p [Pa] is the pressure,
					state [-] is a string representing the phase of the mixture ('V' or 'L').
					
18) phi_RKmix: 	function that returns the fugacity coefficient [-], predicted by the RK cubic equation, of a compound in a mixture from the values index,x,NC,Tc,pc,T,pressure,state where:
					index [-] is the index of the species of interest (index against one of the following vectors, must be a number between 1 and NC),
					x [-] is the vector of compositions,
					NC [-] is the number of components (size of vector x),
					Tc [K] is the vector of critical temperatures of pure compounds,
					pc [Pa] is the vector of critical pressures of pure compounds,
					T [K] is the temperature,
					p [Pa] is the pressure,
					state [-] is a string representing the phase of the mixture ('V' or 'L').
					
19) phi_RKSmix: 	function that returns the fugacity coefficient [-], predicted by the RKS cubic equation, of a compound in a mixture from the values index,x,NC,Tc,pc,w,T,pressure,state where:
					index [-] is the index of the species of interest (index against one of the following vectors, must be a number between 1 and NC),
					x [-] is the vector of compositions,
					NC [-] is the number of components (size of vector x),
					Tc [K] is the vector of critical temperatures of pure compounds,
					pc [Pa] is the vector of critical pressures of pure compounds,
					w [-] is the vector of Pitzer acentric factor of pure compounds,
					T [K] is the temperature,
					p [Pa] is the pressure,
					state [-] is a string representing the phase of the mixture ('V' or 'L').
					
20) phi_PRmix: 		function that returns the fugacity coefficient [-], predicted by the PR cubic equation, of a compound in a mixture from the values index,x,NC,Tc,pc,w,T,pressure,state where:
					index [-] is the index of the species of interest (index against one of the following vectors, must be a number between 1 and NC),
					x [-] is the vector of compositions,
					NC [-] is the number of components (size of vector x),
					Tc [K] is the vector of critical temperatures of pure compounds,
					pc [Pa] is the vector of critical pressures of pure compounds,
					w [-] is the vector of Pitzer acentric factor of pure compounds,
					T [K] is the temperature,
					p [Pa] is the pressure,
					state [-] is a string representing the phase of the mixture ('V' or 'L').
					
21) hR_VdWmix: 		function that returns the residual enthalpy [J/mol], predicted by the cubic VdW equation, of a mixture from the values x,NC,Tc,pc,T,pressure,state where:
					x [-] is the vector of compositions,
					NC [-] is the number of components (size of vector x),
					Tc [K] is the vector of critical temperatures of pure compounds,
					pc [Pa] is the vector of critical pressures of pure compounds,
					T [K] is the temperature,
					p [Pa] is the pressure,
					state [-] is a string representing the phase of the mixture ('V' or 'L').
					
22) hR_RKmix: 		function that returns the residual enthalpy [J/mol], predicted by the RK cubic equation, of a mixture from the values x,NC,Tc,pc,T,pressure,state where:
					x [-] is the vector of compositions,
					NC [-] is the number of components (size of vector x),
					Tc [K] is the vector of critical temperatures of pure compounds,
					pc [Pa] is the vector of critical pressures of pure compounds,
					T [K] is the temperature,
					p [Pa] is the pressure,
					state [-] is a string representing the phase of the mixture ('V' or 'L').
					
23) hR_RKSmix: 		function that returns the residual enthalpy [J/mol], predicted by the RKS cubic equation, of a mixture from the values x,NC,Tc,pc,w,T,pressure,state where:
					x [-] is the vector of compositions,
					NC [-] is the number of components (size of vector x),
					Tc [K] is the vector of critical temperatures of pure compounds,
					pc [Pa] is the vector of critical pressures of pure compounds,
					w [-] is the vector of Pitzer acentric factor of pure compounds,
					T [K] is the temperature,
					p [Pa] is the pressure,
					state [-] is a string representing the phase of the mixture ('V' or 'L').
					
24) hR_PRmix: 		function that returns the residual enthalpy [J/mol], predicted by the PR cubic equation, of a mixture from the values x,NC,Tc,pc,w,T,pressure,state where:
					x [-] is the vector of compositions,
					NC [-] is the number of components (size of vector x),
					Tc [K] is the vector of critical temperatures of pure compounds,
					pc [Pa] is the vector of critical pressures of pure compounds,
					w [-] is the vector of Pitzer acentric factor of pure compounds,
					T [K] is the temperature,
					p [Pa] is the pressure,
					state [-] is a string representing the phase of the mixture ('V' or 'L').

					
Support my work: https://paypal.me/eliaferretti .
For any problems or bugs, please contact the developer at: eliaferretti@outlook.it


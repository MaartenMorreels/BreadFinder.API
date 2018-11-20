// vue.js file

const url = "http://localhost:5000/api/automaten"

const vm = new Vue({
    el: "#automatenTabelAdmin",
    data: {
        automaten: []
    },
    mounted() {
        axios.get(url).then(response => {
            this.automaten = response.data
        })
    }
        // automaten: [{
        //         "automaatId": 1,
        //         "automaatStraat": "automaatstraat",
        //         "automaatHuisNr": "1",
        //         "automaatPlaatsId": 0,
        //         "automaatPostCode": "2970",
        //         "automaatPlaatsNaam": "'S Gravenwezel",
        //         "eigenaarId": 1,
        //         "eigenaarNaam": "Eigenaar1",
        //         "eigenaarStraat": "Straat1",
        //         "eigenaarHuisNr": "1",
        //         "eigenaarPlaatsId": 0,
        //         "eigenaarPostCode": "2970",
        //         "eigenaarPlaatsNaam": "'S Gravenwezel",
        //         "eigenaarTelefoon": "016/123456",
        //         "eigenaarWebsite": "www.w1.be",
        //         "eigenaarEmail": "eigenaar1@gmail.com"
        //     },
        //     {
        //         "automaatId": 2,
        //         "automaatStraat": "automaatstraat",
        //         "automaatHuisNr": "2",
        //         "automaatPlaatsId": 0,
        //         "automaatPostCode": "2970",
        //         "automaatPlaatsNaam": "'S Gravenwezel",
        //         "eigenaarId": 2,
        //         "eigenaarNaam": "Eigenaar2",
        //         "eigenaarStraat": "Straat2",
        //         "eigenaarHuisNr": "2",
        //         "eigenaarPlaatsId": 0,
        //         "eigenaarPostCode": "2970",
        //         "eigenaarPlaatsNaam": "'S Gravenwezel",
        //         "eigenaarTelefoon": "016/456789",
        //         "eigenaarWebsite": "www.w2.be",
        //         "eigenaarEmail": "eigenaar2@gmail.com"
        //     },
        //     {
        //         "automaatId": 3,
        //         "automaatStraat": "automaatstraat",
        //         "automaatHuisNr": "3",
        //         "automaatPlaatsId": 0,
        //         "automaatPostCode": "2970",
        //         "automaatPlaatsNaam": "'S Gravenwezel",
        //         "eigenaarId": 3,
        //         "eigenaarNaam": "Eigenaar3",
        //         "eigenaarStraat": "straat3",
        //         "eigenaarHuisNr": "3",
        //         "eigenaarPlaatsId": 0,
        //         "eigenaarPostCode": "2970",
        //         "eigenaarPlaatsNaam": "'S Gravenwezel",
        //         "eigenaarTelefoon": "016/111111",
        //         "eigenaarWebsite": "www.w3.be",
        //         "eigenaarEmail": "eigenaar3@gmail.com"
        //     }
        // ]
    
})
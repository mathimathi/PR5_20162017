app.controller("DeckController", function ($scope, deckservice) {
    $scope.GetDecks = function () {
        $scope.data = deckservice.query();
    }
    $scope.PostDeck = function () {
        var card1 = {
            "Id": 0
            , "Cardname": "Lich"
            , "Cardlink": "http://deckbox.org/system/images/mtg/cards/666.jpg"
        };
        var card2 = {
            "Id": 0
            , "Cardname": "Demonic Tutor"
            , "Cardlink": "http://deckbox.org/system/images/mtg/cards/60.jpg"
        };
        var card3 = {
            "Id": 0
            , "Cardname": "Channel"
            , "Cardlink": "http://deckbox.org/system/images/mtg/cards/144.jpg"
        };
        var deck = {
            "Id": 3
            , "Deckname": "Storm Combo"
            , "Creator": "Willy Wortel"
            , "Decklist": [
                card1, card2
            ]
            , "Sideboard": [
                card3
            ]
        };
        deckservice.save(deck);
    }
    /*$scope.GetDeckById = function () {
        $scope.DisplayDeck = deckservice.get({
            deck: 1
        })
    }*/
    $scope.KiesDeck = function (deckid) {
        $scope.DisplayDeck = deckservice.get({
            deck: deckid
        })
    }
    $scope.visible = false;
    $scope.$watch("DisplayDeck", function (newValue, oldValue) {
        if ($scope.DisplayDeck != null) {
            $scope.visible = true;
        }
    })
});
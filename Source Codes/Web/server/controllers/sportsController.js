const Sports = require('../models/SportsSchema');

module.exports = {
    get(req, res) {
        console.log(req.params.type)
        if(req.params.type === "Event")
            Sports.find(
                { "eventName": { "$regex": req.params.search, "$options": "i" } },
                function(err,data) { 
                    res.json({data});
                } 
            ).catch(err => {
                res.json({type: 'error', message: 'Sport not found!'});
            });
        else if(req.params.type === "Sport")
            Sports.find(
                { "sport.name": { "$regex": req.params.search, "$options": "i" } },
                function(err,data) { 
                    res.json({data});
                } 
            ).catch(err => {
                res.json({type: 'error', message: 'Sport not found!'});
            });
        else if(req.params.type === "League")
            Sports.find(
                { "league.name": { "$regex": req.params.search, "$options": "i" } },
                function(err,data) { 
                    res.json({data});
                } 
            ).catch(err => {
                res.json({type: 'error', message: 'Sport not found!'});
            });
    },
    post(req, res) {
        console.log(req.body)
        
        Sports.findById(req.body.item, (err, item) => {
            if(req.body.bet === 0){
                item.homeTeamOdds -= 0.01;
                item.awayTeamOdds += 0.01;
                item.drawOdds += 0.01;
            }
            else if(req.body.bet === 1){
                item.homeTeamOdds += 0.01;
                item.awayTeamOdds -= 0.01;
                item.drawOdds += 0.01;
            }
            else{
                item.homeTeamOdds += 0.01;
                item.awayTeamOdds += 0.01;
                item.drawOdds -= 0.01;
            }
            
            item.save();
        }).then(() => {
            res.json({type: 'info', message: 'Bet successful.'});
        }).catch(() => {
            res.json({type: 'error', message: 'Could not add item.'});
        })
    }
};
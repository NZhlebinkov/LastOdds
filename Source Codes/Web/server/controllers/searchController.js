const Sports = require('../models/SportsSchema');

module.exports = {
    get(req, res) {
        
    },
    post(req, res) {
        console.log(req.params.search)
        Sports.find(
            { "eventName": { "$regex": req.params.search, "$options": "i" } },
            function(err,data) { 
                res.json({data});
            } 
        ).catch(err => {
            res.json({type: 'error', message: 'Sport not found!'});
        });
    }
};
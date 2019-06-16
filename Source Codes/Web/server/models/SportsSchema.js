const mongoose = require('mongoose');

let sportsSchema = new mongoose.Schema({
    eventName: { type: String },
    eventDate: { type: Date },
    hashedPass: { type: String },
    sport: {
        id: {type: Number},
        name: {type: String}
    },
    league: {
        id: {type: Number},
        name: {type: String},
        sportId: {type: Number}
    },
    homeTeamScore: {type: Number},
    awayTeamScore: {type: Number},
    homeTeamOdds: {type: Number},
    awayTeamOdds: {type: Number},
    drawOdds: {type: Number}
});

module.exports = mongoose.model("Sports", sportsSchema);

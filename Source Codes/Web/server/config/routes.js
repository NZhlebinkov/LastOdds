const authController = require('../controllers/authController');
const sportsController = require('../controllers/sportsController');
const path = require('path');
const multer = require('multer');
const storage = multer.memoryStorage();
const upload = multer({ storage });


module.exports = app => {
    app.use('/', authController);
    app.get('/api/sports/:type/:search', sportsController.get);
    app.post('/api/sports', sportsController.post);
    
    app.get('*', function (req, res) {
        res.sendFile(path.join(__dirname, '../build', 'index.html'));
    });
};
const crypto = require('crypto')

module.exports = {
  generateSalt: () => {
    return crypto.randomBytes(128).toString('base64')
  },
  generateHashedPassword: (salt, password) => {
    return crypto.createHmac('sha512', salt).update(password).digest('hex')
  }
}

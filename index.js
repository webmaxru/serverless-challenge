const https = require('https');

module.exports = function(context, request) {
  const options = {
    hostname: 'serverless-challenge.azurewebsites.net',
    port: 443,
    path: '/api/serverless-challenge-checker',
    method: 'GET'
  };

  const req = https.request(options, res => {
    res.on('data', data => {
      context.res = {
        status: 200,
        body:
          '<html><head><meta http-equiv="refresh" content="1;url=' +
          data +
          '"></head><body>On the way to the win...</body></html>',
        headers: {
          'Content-Type': 'text/html'
        }
      };
      context.done();
    });
  });

  req.on('error', error => {
    context.res = {
      status: 400,
      body: error
    };

    context.done();
  });

  req.end();
};

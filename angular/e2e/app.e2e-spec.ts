import { angular-netTemplatePage } from './app.po';

describe('angular-net App', function() {
  let page: angular-netTemplatePage;

  beforeEach(() => {
    page = new angular-netTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});

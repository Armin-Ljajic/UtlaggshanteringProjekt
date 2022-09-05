import { TestBed } from '@angular/core/testing';

import { UserexpenceService } from './userexpence.service';

describe('UserexpenceService', () => {
  let service: UserexpenceService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(UserexpenceService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
